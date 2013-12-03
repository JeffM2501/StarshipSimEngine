using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics.OpenGL;

using EntityLocationRendering;
using SimCore.Entities;

namespace EntityBuilder
{
    partial class MainForm
    {
        public bool XYGrid = true;
        public bool ShowGrid = true;

        EntityLocationRenderer Renderer = null;

        // camera values
        float Spin = -45;
        float Tilt = 45;
        float Zoom = 50;
        float FOV = 60;

        Vector3 ViewCenter = new Vector3(0, 0, 0);

        protected Color BackgroundColor = Color.Black;
        protected Color MajorGridColor = Color.Gray;
        protected Color MinorGridColor = Color.DarkGray;

        private Color SelectionColor = Color.LightGreen;
        private Color DeselectedColor = Color.Gray;
        private Color NoSelectionColor = Color.White;

        protected float ZoomPerClick = 1;

        EntityRenderingOptions RenderOptions = new EntityRenderingOptions();

        protected void InitGUI()
        {
            // set any checkboxes and shit
            vissibleToolStripMenuItem.Checked = ShowGrid;

            xYToolStripMenuItem.Checked = XYGrid;
            yZToolStripMenuItem.Checked = !XYGrid;

            solidToolStripMenuItem.Checked = RenderOptions.Solid;
            wireframeToolStripMenuItem.Checked = !RenderOptions.Solid;

            orthographicToolStripMenuItem.Checked = Prefs.GetPrefs().OrthographicView;
            perspectiveToolStripMenuItem.Checked = !orthographicToolStripMenuItem.Checked;

            connectionsToolStripMenuItem.Checked = RenderOptions.ShowConnections;
            systemsToolStripMenuItem.Checked = RenderOptions.ShowSystems;
       
        }

        protected void SetupRendering()
        {
            Renderer = new EntityLocationRenderer(TheEntity);
            Renderer.LineWidth = Prefs.GetPrefs().LineWidth;
            Renderer.GetColorForLocation = GetColorForLocation;
            Renderer.GetColorForConnection = GetColorForConnection;
            ResetColors();
            //RenderOptions.Solid = true;

           
            Draw();
        }

        public void ResetColors()
        {
            Prefs prefs = Prefs.GetPrefs();

            try
            {
                BackgroundColor = Color.FromArgb(prefs.BackgroundColor[0], prefs.BackgroundColor[1], prefs.BackgroundColor[2]);
                MajorGridColor = Color.FromArgb(prefs.MajorGridColor[0], prefs.MajorGridColor[1], prefs.MajorGridColor[2]);
                MinorGridColor = Color.FromArgb(prefs.MinorGridColor[0], prefs.MinorGridColor[1], prefs.MinorGridColor[2]);
            }
            catch (System.Exception ex)
            {
            	
            }

            GL.ClearColor(BackgroundColor);
        }

        protected Color GetColorForLocation(Entity.InternalLocation loc)
        {
            Entity.InternalLocation selectedLoc = GetSelectedLocation();
            if (selectedLoc == null)
                return NoSelectionColor;

            if (loc == selectedLoc)
                return SelectionColor;

            Entity.InternalLocation.ConnectionInfo selectedConnection = GetSelectedConnection();
            if (selectedConnection != null && selectedConnection.TargetIndex >= 0 && TheEntity.Locations[selectedConnection.TargetIndex] == loc)
                return Color.Yellow;

            return DeselectedColor;
        }

        protected Color GetColorForConnection(Entity.InternalLocation location, Entity.InternalLocation.ConnectionInfo connection, int connectionIndex)
        {
            Entity.InternalLocation selectedLoc = GetSelectedLocation();

            if (connection == null)
                return selectedLoc == location ? Color.Indigo : Color.CadetBlue;

            Entity.InternalLocation.ConnectionInfo selectedConnection = GetSelectedConnection();

            if (selectedConnection == connection)
                return Color.Green;
            return Color.LightBlue;
        }

        private void Visualisation_Load(object sender, EventArgs e)
        {
            Visualisation.MouseDown += new MouseEventHandler(Visualisation_MouseDown);
            ResetColors();

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

            // setup lights0
            Vector4 lightInfo = new Vector4(0.25f, 0.25f, 0.25f, 1.0f);
            GL.Light(LightName.Light0, LightParameter.Ambient, lightInfo);
            GL.Light(LightName.Light1, LightParameter.Ambient, lightInfo);

            lightInfo = new Vector4(0.7f, 0.7f, 0.7f, 1.0f);
            GL.Light(LightName.Light0, LightParameter.Diffuse, lightInfo);

            lightInfo = new Vector4(0.5f, 0.5f, 0.5f, 1.0f);
            GL.Light(LightName.Light1, LightParameter.Diffuse, lightInfo);

            Visualisation_Resize(Visualisation, EventArgs.Empty);
        }

        void Visualisation_MouseDown(object sender, MouseEventArgs e)
        {
            DeselectComponents();
        }

        void Visualisation_Resize(object sender, EventArgs e)
        {
            float aspect = 1;
            if (Visualisation.Height != 0)
                aspect = (float)Visualisation.Width / (float)Visualisation.Height;

            float fov = FOV / aspect;

            GL.Viewport(0, 0, Visualisation.Width, Visualisation.Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            if (Prefs.GetPrefs().OrthographicView)
                GL.Ortho(0, Visualisation.Width, 0, Visualisation.Height, 1, 10000);
            else
            {
                Matrix4 mat = Matrix4.CreatePerspectiveFieldOfView((float)(fov * (Math.PI/180.0)), aspect, 1, 10000);
                GL.MultMatrix(ref mat);
            }
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void SetupCamera()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Disable(EnableCap.Texture2D);
            GL.Disable(EnableCap.Lighting);

            if (Prefs.GetPrefs().OrthographicView)
            {
                GL.Translate(Visualisation.Width / 2, Visualisation.Height / 2, -1000);
                float scale = (1 / Zoom) * 500;///2.0f;
                GL.Scale(scale, scale, scale);
                GL.Rotate((Tilt - 90), 1, 0, 0);
                GL.Rotate(-(Spin), 0, 0, 1);

                GL.Translate(-ViewCenter.X, -ViewCenter.Z, ViewCenter.Y);   // take us to the pos
            }
            else
            {
                GL.Translate(0, 0, -Zoom);						            // pull back on along the zoom vector
                GL.Rotate(Tilt, 1.0f, 0.0f, 0.0f);					        // pops us to the tilt
                GL.Rotate(-Spin, 0.0f, 1.0f, 0.0f);                  // gets us on our rot
                GL.Translate(-ViewCenter.X, -ViewCenter.Z, ViewCenter.Y);   // take us to the pos
                GL.Rotate(-90, 1.0f, 0.0f, 0.0f);				            // gets us into XY
            }
        }

        protected void DrawGrid()
        {
            if (!ShowGrid)
                return;

            Prefs prefs = Prefs.GetPrefs();
            float bounds = prefs.MinorGridSpacing * 100;

            float gridZ = 0;

            GL.Color3(MinorGridColor);
            GL.Begin(BeginMode.Lines);
            for (float x = -bounds; x <= bounds; x += prefs.MinorGridSpacing)
            {
                GL.Vertex3(x, -bounds, gridZ);
                GL.Vertex3(x, bounds, gridZ);

                GL.Vertex3(-bounds, x, gridZ);
                GL.Vertex3(bounds, x, gridZ);
            }
            GL.End();

            GL.LineWidth(2);
            GL.Color3(MajorGridColor);
            GL.Begin(BeginMode.Lines);
            for (float x = -bounds; x <= bounds; x += prefs.MajorGridSpacing)
            {
                GL.Vertex3(x, -bounds, gridZ);
                GL.Vertex3(x, bounds, gridZ);

                GL.Vertex3(-bounds, x, gridZ);
                GL.Vertex3(bounds, x, gridZ);
            }
            GL.End();
            GL.LineWidth(1);
        }

        public void DrawWorkspace()
        {
            GL.DepthMask(false);

            GL.PushMatrix();
            if (!XYGrid)
                GL.Rotate(90, 0, 1, 0);
            DrawGrid();
            GL.PopMatrix();
            GL.DepthMask(true);

            GL.LineWidth(1);

            EntityLocationRenderer.DrawOriginMarker(Prefs.GetPrefs().OriginSize);
        }

        public void Draw()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            // draw
            SetupCamera();
            GL.Disable(EnableCap.Lighting);
            DrawWorkspace();

            if (Renderer != null)
                Renderer.Draw(RenderOptions);

            Visualisation.SwapBuffers();
        }

        private void Visualisation_Paint(object sender, PaintEventArgs e)
        {
            Draw();
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

        private void SpinBack_Click(object sender, EventArgs e)
        {
            Tilt += 5;
            Draw();
        }

        private void SpinUp_Click(object sender, EventArgs e)
        {
            Tilt -= 5;
            Draw();
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            Zoom -= ZoomPerClick;
            if (Zoom < 0)
                Zoom = 0;
            Draw();
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            Zoom += ZoomPerClick;
            Draw();
        }

        private void resetFocusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCenter = Vector3.Zero;
            Draw();
        }

        private void focusSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation location = GetSelectedLocation();
            if (location == null)
                return;

            ViewCenter = new Vector3((float)location.Origin.X, (float)location.Origin.Y, (float)location.Origin.Z);
            Draw();
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCenter = Vector3.Zero;
            Spin = 0;
            Tilt = 90;
            Draw();
        }

        private void sideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCenter = Vector3.Zero;
            Spin = -90;
            Tilt = 0;
            Draw();
        }

        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCenter = Vector3.Zero;
            Spin = 180;
            Tilt = 0;
            Draw();
        }

        private void isometricToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCenter = Vector3.Zero;
            Spin = -45;
            Tilt = 45;
            Draw();
        }

        private void orthographicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prefs.GetPrefs().OrthographicView = true;
            Prefs.Save();

            orthographicToolStripMenuItem.Checked = true;
            perspectiveToolStripMenuItem.Checked = false;

            Visualisation_Resize(Visualisation, EventArgs.Empty);
            Draw();
        }

        private void perspectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prefs.GetPrefs().OrthographicView = false;
            Prefs.Save();

            orthographicToolStripMenuItem.Checked = false;
            perspectiveToolStripMenuItem.Checked = true;

            Visualisation_Resize(Visualisation, EventArgs.Empty);
            Draw();
        }

        private void xYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XYGrid = true;
            xYToolStripMenuItem.Checked = true;
            yZToolStripMenuItem.Checked = false;
            Draw();
        }

        private void yZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XYGrid = false;
            xYToolStripMenuItem.Checked = false;
            yZToolStripMenuItem.Checked = true;
            Draw();
        }

        private void vissibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGrid = !vissibleToolStripMenuItem.Checked;
            vissibleToolStripMenuItem.Checked = ShowGrid;
            Draw();
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderOptions.Solid = true;
            solidToolStripMenuItem.Checked = true;
            wireframeToolStripMenuItem.Checked = false;
            Draw();
        }

        private void wireframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderOptions.Solid = false;
            solidToolStripMenuItem.Checked = false;
            wireframeToolStripMenuItem.Checked = true;
            Draw();
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderOptions.ShowConnections = !RenderOptions.ShowConnections;
            connectionsToolStripMenuItem.Checked = RenderOptions.ShowConnections;
            Draw();
        }

        private void systemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderOptions.ShowSystems = !RenderOptions.ShowSystems;
            systemsToolStripMenuItem.Checked = RenderOptions.ShowSystems;
            Draw();
        }
    }
}
