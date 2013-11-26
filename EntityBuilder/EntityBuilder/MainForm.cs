using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenTK.Graphics;

using SimCore;
using SimCore.Entities;
using SimCore.Data;
using SimCore.Data.Systems;
using SimCore.Actors;

using EntityBuilder.Inspectors;
using OpenTK;


namespace EntityBuilder
{
    public partial class MainForm : Form
    {
        Entity TheEntity = null;

        public MainForm()
        {
            InitializeComponent();

            Visualisation.Resize += new EventHandler(Visualisation_Resize);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntityTypeSelector selector = new EntityTypeSelector();
            if (selector.ShowDialog(this) == DialogResult.OK)
            {
                if (selector.IsShip)
                {
                    TheEntity = new StarShip();
                }
                else
                {
                    TheEntity = new CelestialObject();
                    (TheEntity as CelestialObject).Category = selector.CelestialCategory;
                }

                TheEntity.Name = selector.Name;
            }

            EntityChanged();
        }

        protected void EntityChanged()
        {
            this.Text = TheEntity.Name;

            ComponentViewModeList.SelectedIndex = -1;
            ComponentViewModeList.SelectedIndex = 0;
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
            inspector.LocationNameChanged += new EventHandler(inspector_LocationNameChanged);
            inspector.LocationGeometryChanged += new EventHandler(inspector_LocationGeometryChanged);
            inspector.Show();
        }

        void inspector_LocationGeometryChanged(object sender, EventArgs e)
        {
            Draw();
        }

        void inspector_LocationNameChanged(object sender, EventArgs e)
        {
            LocationInspector inspector = sender as LocationInspector;
            if (sender == null)
                return;

            foreach (TreeNode node in ComponentsList.Nodes)
            {
                if (ViewByLocation())
                {
                    if (node.Tag == inspector.Location)
                        node.Text = inspector.Location.Name;
                }
                else
                {
                    foreach (TreeNode n in node.Nodes)
                    {
                        if (n.Tag == inspector.Location)
                            n.Text = inspector.Location.Name;
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

            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.FrontFace(FrontFaceDirection.Ccw);
            GL.ShadeModel(ShadingModel.Smooth);
            GL.PolygonMode(MaterialFace.Front, PolygonMode.Line);
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
            float spin = 45;
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

        public void Draw()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            // draw
            SetupCamera();
            DrawOrigin(5);

            Visualisation.SwapBuffers();
        }

        private void Visualisation_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
    }
}
