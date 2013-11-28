using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using SimCore.Entities;
using SimCore.Data;
using SimCore.Actors;

using OpenTK;
using OpenTK.Graphics;

namespace EntityLocationRendering
{
    public class EntityRenderingOptions
    {
        public bool Solid = false;
        public bool ShowSystems = true;
        public float LineWidth = 1;
    }

    public class EntityLocationRenderer
    {
        public Entity TheEntity = null;

        public delegate Color LocationColorCallback(Entity.InternalLocation location);
        public LocationColorCallback GetColorForLocation;

        public float LineWidth = 1;

        public EntityLocationRenderer(Entity ent)
        {
            TheEntity = ent;
            GetColorForLocation = DefaultColorCallback;
        }

        protected Color DefaultColorCallback(Entity.InternalLocation location)
        {
            return Color.White;
        }

        public static void DrawOriginMarker(float size)
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

        protected EntityRenderingOptions RenderingOptions = null;

        protected bool SetOptions()
        {
            if (RenderingOptions.Solid)
            {
                GL.Enable(EnableCap.Light0);
                GL.Enable(EnableCap.Light1);

                Vector4 lightPos = new Vector4(750f, 500f, 1000f, 1f);
                GL.Light(LightName.Light0, LightParameter.Position, lightPos);

                lightPos = new Vector4(0, 500f, -1000f, 1f);
                GL.Light(LightName.Light1, LightParameter.Position, lightPos);

                GL.PolygonMode(MaterialFace.Front, PolygonMode.Fill);
                GL.PolygonMode(MaterialFace.Back, PolygonMode.Fill);

                return true;
            }
            else
            {
                GL.PolygonMode(MaterialFace.Front, PolygonMode.Line);
                GL.PolygonMode(MaterialFace.Back, PolygonMode.Line);
            }
            return false;
        }

        protected void DrawCylinder(double lowerRad, double upperRad, double height, int segments)
        {
            Glu.Cylinder(QuadricCache, lowerRad, upperRad, height, segments, 1);

            if (RenderingOptions.Solid)
            {
                GL.PushMatrix();
                GL.Translate(0, 0, height);
                Glu.Disk(QuadricCache, 0, lowerRad, segments, 1);

                GL.Translate(0, 0, -height);

                GL.Rotate(180, 1, 0, 0);
                Glu.Disk(QuadricCache, 0, lowerRad, segments, 1);

                GL.PopMatrix();
            }
        }

        IntPtr QuadricCache;
        public void Draw(EntityRenderingOptions options)
        {
            RenderingOptions = options;

            GL.LineWidth(RenderingOptions.LineWidth);
            QuadricCache = Glu.NewQuadric();

            bool useLighting = SetOptions();

            foreach (Entity.InternalLocation loc in TheEntity.Locations)
            {
                GL.PushMatrix();
                GL.Translate(loc.Origin.X,loc.Origin.Y,loc.Origin.Z);

                Vector3d axis = Vector3d.Zero;
                double angle = 0;
                loc.Orientation.ToAxisAngle(out axis, out angle);

                Matrix4d mat = Matrix4d.CreateFromAxisAngle(axis,angle);
                GL.MultMatrix(ref mat);

                GL.Disable(EnableCap.Lighting);
                DrawOriginMarker(1);

                if (useLighting)
                    GL.Enable(EnableCap.Lighting);

                GL.Color3(GetColorForLocation(loc));

                switch (loc.Shape)
                {
                    case Entity.InternalLocation.LocaionShapes.Rectangular:
                        GL.Scale(loc.Size.X * 0.5f, loc.Size.Y * 0.5f, loc.Size.Z); 
                        GL.Rotate(45, Vector3.UnitZ);
                        DrawCylinder(1, 1, 1, 4);
                        break;

                    case Entity.InternalLocation.LocaionShapes.Sphere:
                       // GL.Scale(loc.Size.X, loc.Size.Y, loc.Size.Z);
                        Glu.Sphere(QuadricCache, loc.Size.X, 12, 12);
                        break;

                    case Entity.InternalLocation.LocaionShapes.ZCylinder:
                      //  GL.Scale(loc.Size.X, loc.Size.Y, loc.Size.Z);
                        DrawCylinder(loc.Size.X, loc.Size.Y, loc.Size.Z, 24);

                        break;

                    case Entity.InternalLocation.LocaionShapes.YCylinder:
                        GL.Rotate(90.0f, Vector3.UnitX);
                        DrawCylinder(loc.Size.X, loc.Size.Y, loc.Size.Z, 24);
                        break;

                    case Entity.InternalLocation.LocaionShapes.XCylinder:
                        GL.Rotate(90.0f, Vector3.UnitY);
                        DrawCylinder(loc.Size.X, loc.Size.Y, loc.Size.Z, 24);
                        break;
                }

                GL.PopMatrix();

                GL.LineWidth(1);
            }
        }
    }
}
