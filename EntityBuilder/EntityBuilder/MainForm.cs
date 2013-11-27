using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using OpenTK.Graphics;

using SimCore;
using SimCore.Entities;
using SimCore.Data;
using SimCore.Data.Systems;
using SimCore.Actors;

using EntityBuilder.Inspectors;
using OpenTK;

using EntityLocationRendering;


namespace EntityBuilder
{
    public partial class MainForm : Form
    {
        Entity TheEntity = null;
        FileInfo DocumentFile = null;

        EntityLocationRenderer Renderer = null;

        protected bool DocDirty = false;

        // camera values
        float Spin = 45;

        public CelestialObject GetCelestial() { return TheEntity as CelestialObject; }
        public StarShip GetStarShip() { return TheEntity as StarShip; }
        public Planet GetPlanet() { return TheEntity as Planet; }

        private static MainForm CurrentWindow = null;
        public static void SetCurrentDocDirty()
        {
            if (CurrentWindow != null)
                CurrentWindow.Dirty();
        }

        public MainForm()
        {
            CurrentWindow = this;
            InitializeComponent();
            SetUpMRU();
            Visualisation.Resize += new EventHandler(Visualisation_Resize);
        }

        protected void SetUpMRU()
        {
            Prefs prefs = Prefs.GetPrefs();
            recentToolStripMenuItem.DropDownItems.Clear();
            foreach (string file in prefs.RecentFiles)
            {
                ToolStripMenuItem menu = new ToolStripMenuItem(Path.GetFileNameWithoutExtension(file));
                menu.Tag = file;
                menu.Click += new EventHandler(MRUmenu_Click);
                recentToolStripMenuItem.DropDownItems.Add(menu);
            }
        }

        protected void AddMRUItem(string filename)
        {
            Prefs prefs = Prefs.GetPrefs();

            if (prefs.RecentFiles.Contains(filename))
                prefs.RecentFiles.Remove(filename);

            prefs.RecentFiles.Insert(0,filename);
            if (prefs.RecentFiles.Count > prefs.MaxRecentlyUsedFiles)
                prefs.RecentFiles.RemoveRange(prefs.MaxRecentlyUsedFiles - 1, prefs.RecentFiles.Count - prefs.MaxRecentlyUsedFiles);

            prefs.Save();
            SetUpMRU();
        }

        protected void EntityChanged()
        {
            this.Text = TheEntity.Name;

            ComponentViewModeList.SelectedIndex = -1;
            ComponentViewModeList.SelectedIndex = 0;

            Renderer = new EntityLocationRenderer(TheEntity);
            Renderer.LineWidth = Prefs.GetPrefs().LineWidth;
            Renderer.GetColorForLocation = GetColorForLocation;
            Draw();
        }

        protected Color GetColorForLocation(Entity.InternalLocation loc)
        {
            if (loc == GetSelectedLocation())
                return Color.Blue;
            return Color.White;
        }

        protected Entity.InternalLocation GetSelectedLocation()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            Entity.InternalLocation loc = ComponentsList.SelectedNode.Tag as Entity.InternalLocation;

            if (loc != null)
                return loc;

            BaseSystem sys = ComponentsList.SelectedNode.Tag as BaseSystem;
            if (sys == null || sys.LocationID < 0 || sys.LocationID >= TheEntity.Locations.Count)
                return null;

            return TheEntity.Locations[sys.LocationID];
        }

        protected BaseSystem GetSelectedSystem()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            Entity.InternalLocation loc = ComponentsList.SelectedNode.Tag as Entity.InternalLocation;

            if (loc != null)
                return null;

            BaseSystem sys = ComponentsList.SelectedNode.Tag as BaseSystem;
            if (sys == null || sys.LocationID < 0 || sys.LocationID >= TheEntity.Locations.Count)
                return null;

            return sys;
        }

        public bool ViewByLocation()
        {
            return ComponentViewModeList.SelectedIndex == 0;
        }

        private void ComponentViewModeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComponentsList.Nodes.Clear();

            if (ViewByLocation())
                BuildLocationList();
        }

        public void AddSystemsToNode(IEnumerable<BaseSystem> systemList, TreeNode root, int locID)
        {
            foreach (BaseSystem system in systemList)
            {
                if (system.LocationID != locID)
                    continue;
                
                TreeNode node = new TreeNode(system.Name);
                node.Tag = system;
                root.Nodes.Add(node);
            }
        }

        public void BuildLocationList()
        {
            foreach (Entity.InternalLocation loc in TheEntity.Locations)
            {
                TreeNode node = new TreeNode(loc.ToString());
                node.Tag = loc;
                ComponentsList.Nodes.Add(node);

                AddSystemsToNode(TheEntity.Engines,node,loc.Index);
                AddSystemsToNode(TheEntity.StorageSystems,node,loc.Index);
                AddSystemsToNode(TheEntity.FluidTanks,node,loc.Index);
                AddSystemsToNode(TheEntity.PropulsionSystems,node,loc.Index);
                AddSystemsToNode(TheEntity.NavigationSystems,node,loc.Index);
                AddSystemsToNode(TheEntity.DefensiveSystems,node,loc.Index);
                AddSystemsToNode(TheEntity.MedicalSystems,node,loc.Index);
                AddSystemsToNode(TheEntity.LifeSupportDistrobutions,node,loc.Index);
                AddSystemsToNode(TheEntity.LifeSupportRecyclers,node,loc.Index);
                AddSystemsToNode(TheEntity.Hangars,node,loc.Index);
                AddSystemsToNode(TheEntity.Sensors,node,loc.Index);
                AddSystemsToNode(TheEntity.Transporters,node,loc.Index);
                AddSystemsToNode(TheEntity.TractorBeams,node,loc.Index);
                AddSystemsToNode(TheEntity.Computers,node,loc.Index);
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation location = new Entity.InternalLocation();
            location.Name = "New Location";
            TheEntity.Locations.Add(location);

            if (ViewByLocation())
            {
                TreeNode node = new TreeNode(location.ToString());
                node.Tag = location;
                ComponentsList.Nodes.Add(node);
                ComponentsList.SelectedNode = node;
            }
        }

        public void LoadLocationInspector(Entity.InternalLocation location)
        {
            InspectorArea.Controls.Clear();
            LocationInspector inspector = new LocationInspector(location);
            InspectorArea.Controls.Add(inspector);
            inspector.NameChanged += new EventHandler(inspector_LocationNameChanged);
            inspector.InfoChanged += new EventHandler(inspector_LocationGeometryChanged);
            inspector.Show();
        }

        void inspector_LocationGeometryChanged(object sender, EventArgs e)
        {
            Dirty();
        }

        void inspector_LocationNameChanged(object sender, EventArgs e)
        {
            Entity.InternalLocation location = sender as Entity.InternalLocation;
            if (location == null)
                return;

            foreach (TreeNode node in ComponentsList.Nodes)
            {
                if (ViewByLocation())
                {
                    if (node.Tag == location)
                        node.Text = location.Name;
                }
                else
                {
                    foreach (TreeNode n in node.Nodes)
                    {
                        if (n.Tag == location)
                            n.Text = location.Name;
                    }
                }
            }
        }

        private void ComponentsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            BaseSystem system = GetSelectedSystem();
            if (system != null)
            {

            }
            else
            {
                Entity.InternalLocation location = GetSelectedLocation();

                if (location != null)
                    LoadLocationInspector(location);
            }

            Draw();
        }

        private void ComponentContextMenu_Opening(object sender, CancelEventArgs e)
        {
            ComponentContextMenu.Enabled = TheEntity != null;
            foreach (ToolStripItem item in locationToolStripMenuItem.DropDownItems)
                item.Enabled = locationToolStripMenuItem.Enabled;
        }

        private void locationToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            locationToolStripMenuItem.Enabled = TheEntity != null;
            foreach(ToolStripItem item in locationToolStripMenuItem.DropDownItems)
                item.Enabled = locationToolStripMenuItem.Enabled;
        }

        private void systemToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            systemToolStripMenuItem.Enabled = TheEntity != null;
            foreach (ToolStripItem item in systemToolStripMenuItem.DropDownItems)
                item.Enabled = systemToolStripMenuItem.Enabled;
        }

        private void Visualisation_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);

            GL.Disable(EnableCap.CullFace);
           //GL.CullFace(CullFaceMode.Back);
            GL.FrontFace(FrontFaceDirection.Ccw);
            GL.ShadeModel(ShadingModel.Flat);
            GL.PolygonMode(MaterialFace.Front, PolygonMode.Line);
            GL.PolygonMode(MaterialFace.Back, PolygonMode.Line);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Enable(EnableCap.ColorMaterial);
            GL.Enable(EnableCap.LineSmooth);
            GL.Enable(EnableCap.DepthTest);
        }

        void Visualisation_Resize(object sender, EventArgs e)
        {
            float aspect = 1;
            if (Visualisation.Height != 0)
                aspect = (float)Visualisation.Width / (float)Visualisation.Height;

            float fov = 90.0f / aspect;

            GL.Viewport(0, 0, Visualisation.Width, Visualisation.Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Glu.Perspective(fov, aspect, 1, 10000);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void SetupCamera()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Disable(EnableCap.Texture2D);
            GL.Disable(EnableCap.Lighting);

            float pullback = 10;
            float tilt = 45;
            float spin = Spin;
            Vector3 viewPos = new Vector3(0,0,0);

            GL.Translate(0, 0, -pullback);						// pull back on along the zoom vector
            GL.Rotate(tilt, 1.0f, 0.0f, 0.0f);					// pops us to the tilt
            GL.Rotate(-spin + 90.0, 0.0f, 1.0f, 0.0f);          // gets us on our rot
            GL.Translate(-viewPos.X, -viewPos.Z, viewPos.Y);    // take us to the pos
            GL.Rotate(-90, 1.0f, 0.0f, 0.0f);				    // gets us into XY
        }

        void DrawOrigin(float size)
        {
            GL.Begin(BeginMode.Lines);

            GL.Color3(Color.Red);
            GL.Vertex3(Vector3.Zero);
            GL.Vertex3(Vector3.UnitX * size);

            GL.Color3(Color.Green);
            GL.Vertex3(Vector3.Zero);
            GL.Vertex3(Vector3.UnitY * size);

            GL.Color3(Color.Blue);
            GL.Vertex3(Vector3.Zero);
            GL.Vertex3(Vector3.UnitZ * size);

            GL.End();
        }

        public void Dirty()
        {
            DocDirty = true;
            Draw();
        }

        public void Draw()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            // draw
            SetupCamera();
            DrawOrigin(5);

            if (Renderer != null)
                Renderer.Draw();

            Visualisation.SwapBuffers();
        }

        private void Visualisation_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        protected Type GetDeserializationType(string filename)
        {
            Type serialType = typeof(Entity);

            XmlReader reader = XmlReader.Create(filename);

            bool isCelestial = false;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "EntityType")
                        {
                            reader.Read();
                            if (reader.NodeType != XmlNodeType.Text)
                                continue;

                            if (reader.Value == "Ship")
                                return typeof(StarShip);
                            else if (reader.Value == "Celestial")
                                isCelestial = true;
                            else
                                return typeof(Entity);
                        }
                        else if (reader.Name == "Category" && isCelestial)
                        {
                            reader.Read();
                            if (reader.NodeType != XmlNodeType.Text)
                                continue;

                            if (reader.Value == "Planet")
                                return typeof(Planet);
                            else
                                return typeof(CelestialObject);
                        }
                        break;
                }
            }

            return serialType;
        }

        protected Type GetSerializationType()
        {
            Type serialType = typeof(Entity);

            if (TheEntity.EntityType == Entity.EntityTypes.Celestial)
            {
                serialType = typeof(CelestialObject);
                CelestialObject celestial = GetCelestial();
                if (celestial.Category == CelestialObject.Categories.Planet)
                    serialType = typeof(Planet);
            }
            else if (TheEntity.EntityType == Entity.EntityTypes.Ship)
                serialType = typeof(StarShip);

            return serialType;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DocDirty)
                saveToolStripMenuItem_Click(this, EventArgs.Empty);

            DocDirty = false;

            EntityTypeSelector selector = new EntityTypeSelector();
            if (selector.ShowDialog(this) == DialogResult.OK)
            {
                DocumentFile = null;
                if (selector.IsShip)
                {
                    TheEntity = new StarShip();
                }
                else
                {
                    if (selector.CelestialCategory == CelestialObject.Categories.Planet)
                        TheEntity = new Planet();
                    else
                    {
                        TheEntity = new CelestialObject();
                        (TheEntity as CelestialObject).Category = selector.CelestialCategory;
                    }
                }

                TheEntity.Name = selector.Name;
                EntityChanged();
            }
        }

        void MRUmenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if (menu == null || menu.Tag == null)
                return;

            OpenFile(menu.Tag as string);
        }

        protected void OpenFile(string fileName)
        {
            if (DocDirty)
                saveToolStripMenuItem_Click(this, EventArgs.Empty);

            DocDirty = false;

            FileInfo file = new FileInfo(fileName);
            if (!file.Exists)
                return;

            XmlSerializer xml = new XmlSerializer(GetDeserializationType(fileName));
            Stream fs = file.OpenRead();
            TheEntity = xml.Deserialize(fs) as Entity;
            fs.Close();

            DocumentFile = file;
            AddMRUItem(DocumentFile.FullName);
            EntityChanged();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Extensible Markup Language files (*.XML)|*.xml|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog(this) == DialogResult.OK)
                OpenFile(ofd.FileName);
        }
       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheEntity == null)
                return;

            if (DocumentFile == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Extensible Markup Language files (*.XML)|*.xml|All files (*.*)|*.*";
                sfd.FilterIndex = 0;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;

                DocumentFile = new FileInfo(sfd.FileName);
                AddMRUItem(DocumentFile.FullName);
            }

            DocumentFile.Delete();

            try
            {
                FileStream fs = DocumentFile.OpenWrite();
                XmlSerializer xml = new XmlSerializer(GetSerializationType());
                xml.Serialize(fs, TheEntity);
                fs.Close();

                DocDirty = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error writing file");
            }
        }

        private void CWRot_Click(object sender, EventArgs e)
        {
            Spin += 5;
            Draw();
        }

        private void CCWRot_Click(object sender, EventArgs e)
        {
            Spin -= 5;
            Draw();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DocDirty)
            {
                if (MessageBox.Show(this,"There are unsaved changes, do you wish to save before closing?","Save changes?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
            }
        }
    }
}
