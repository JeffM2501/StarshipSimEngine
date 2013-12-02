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
        public bool ShowConnections = true;
        public float LineWidth = 1;

        // connector sizes
        public float CenterRadius = 0.25f;
        public float ConnectorRadius = 0.35f;
    }

    public class EntityLocationRenderer
    {
        public Entity TheEntity = null;

        public delegate Color LocationColorCallback(Entity.InternalLocation location);
        public delegate Color ConnectionColorCallback(Entity.InternalLocation location, Entity.InternalLocation.ConnectionInfo connection, int connectionIndex);
        
        public LocationColorCallback GetColorForLocation;
        public ConnectionColorCallback GetColorForConnection;

        public float LineWidth = 1;

        public EntityLocationRenderer(Entity ent)
        {
            TheEntity = ent;
            GetColorForLocation = DefaultLocationColorCallback;
            GetColorForConnection = DefaultConnectionColorCallback;
        }

        protected Color DefaultLocationColorCallback(Entity.InternalLocation location)
        {
            return Color.White;
        }

        protected Color DefaultConnectionColorCallback(Entity.InternalLocation location, Entity.InternalLocation.ConnectionInfo connection, int connectionIndex)
        {
            return connectionIndex < 0 ? Color.Blue : Color.SkyBlue;
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
                SetSolid();
                return true;
            }
            else
            {
                GL.Disable(EnableCap.Lighting);
                GL.PolygonMode(MaterialFace.Front, PolygonMode.Line);
                GL.PolygonMode(MaterialFace.Back, PolygonMode.Line);
            }
            return false;
        }

        protected void SetSolid()
        {
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.Light1);

            Vector4 lightPos = new Vector4(750f, 500f, 1000f, 1f);
            GL.Light(LightName.Light0, LightParameter.Position, lightPos);

            lightPos = new Vector4(0, 500f, -1000f, 1f);
            GL.Light(LightName.Light1, LightParameter.Position, lightPos);

            GL.PolygonMode(MaterialFace.Front, PolygonMode.Fill);
            GL.PolygonMode(MaterialFace.Back, PolygonMode.Fill);

            GL.Enable(EnableCap.Lighting);
        }

        protected Vector3d GetLocationCenter(Entity.InternalLocation loc)
        {
            Vector3d axis = Vector3d.Zero;
            double angle = 0;
            loc.Orientation.ToAxisAngle(out axis, out angle);

            Matrix4d orientationMatrix = Matrix4d.CreateFromAxisAngle(axis,angle);

            Vector3d offset = Vector3d.Zero;

            switch (loc.Shape)
            {
                case Entity.InternalLocation.LocaionShapes.Rectangular:
                case Entity.InternalLocation.LocaionShapes.ZCylinder:
                    offset = new Vector3d(0, 0, loc.Size.Z*0.5);
                    offset = Vector3d.Transform(offset, orientationMatrix);
                    break;

                case Entity.InternalLocation.LocaionShapes.Sphere:
                    break;

                case Entity.InternalLocation.LocaionShapes.YCylinder:
                    offset = new Vector3d(0, -loc.Size.Z*0.5, 0);
                    offset = Vector3d.Transform(offset, orientationMatrix);
                    break;

                case Entity.InternalLocation.LocaionShapes.XCylinder:
                    offset = new Vector3d(-loc.Size.Z*0.5,0,0);
                    offset = Vector3d.Transform(offset, orientationMatrix);
                    break;
            }

            return loc.Origin + offset;
        }

        protected void DrawCylinder(double lowerRad, double upperRad, double height, int segments)
        {
            Glu.Cylinder(QuadricCache, lowerRad, upperRad, height, segments, 1);

            if (RenderingOptions.Solid)
            {
                GL.PushMatrix();
                GL.Translate(0, 0, height);
                Glu.Disk(QuadricCache, 0, upperRad, segments, 1);

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

                DrawOriginMarker(1);

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

                if (!RenderingOptions.Solid)
                {
                    SetSolid();

                    GL.Color3(GetColorForConnection(loc, null, -1));

                    Vector3d center = GetLocationCenter(loc);

                    GL.PushMatrix();
                    GL.Translate(center.X, center.Y, center.Z);
                    Glu.Sphere(QuadricCache, RenderingOptions.CenterRadius, 4, 2);
                    GL.PopMatrix();

                    for (int i = 0; i < loc.Connections.Count; i++)
                    {
                        Entity.InternalLocation.ConnectionInfo connection = loc.Connections[i];
                        GL.Color3(GetColorForConnection(loc, connection, i));

                        GL.Begin(BeginMode.Lines);
                        GL.Vertex3(center.X,center.Y,center.Z);
                        GL.Vertex3(connection.ConnectionPoint.X, connection.ConnectionPoint.Y, connection.ConnectionPoint.Z);
                        GL.End();

                        GL.PushMatrix();
                        GL.Translate(connection.ConnectionPoint.X, connection.ConnectionPoint.Y, connection.ConnectionPoint.Z);
                        Glu.Sphere(QuadricCache,RenderingOptions.ConnectorRadius, 8, 4);
                        GL.PopMatrix();
                    }
                }
                SetOptions();

            }
            GL.LineWidth(1);
        }
    }
}
