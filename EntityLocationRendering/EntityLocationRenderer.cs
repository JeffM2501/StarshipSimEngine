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

        public void Draw()
        {
            GL.LineWidth(LineWidth);
            IntPtr quadric = Glu.NewQuadric();

            foreach (Entity.InternalLocation loc in TheEntity.Locations)
            {
                GL.PushMatrix();
                GL.Translate(loc.Origin.X,loc.Origin.Y,loc.Origin.Z);

                Vector3d axis = Vector3d.Zero;
                double angle = 0;
                loc.Orientation.ToAxisAngle(out axis, out angle);

                 Matrix4d mat = Matrix4d.CreateFromAxisAngle(axis,angle);
                 GL.MultMatrix(ref mat);

                GL.Color3(GetColorForLocation(loc));

                switch (loc.Shape)
                {
                    case Entity.InternalLocation.LocaionShapes.Rectangular:
                        GL.Scale(loc.Size.X, loc.Size.Y, loc.Size.Z); 
                        GL.Rotate(45, Vector3.UnitZ);
                        Glu.Cylinder(quadric, 1,1,1, 4,1);
                        break;

                    case Entity.InternalLocation.LocaionShapes.Sphere:
                       // GL.Scale(loc.Size.X, loc.Size.Y, loc.Size.Z);
                        Glu.Sphere(quadric, loc.Size.X, 8, 8);
                        break;

                    case Entity.InternalLocation.LocaionShapes.ZCylinder:
                      //  GL.Scale(loc.Size.X, loc.Size.Y, loc.Size.Z);
                        Glu.Cylinder(quadric, loc.Size.X, loc.Size.X, loc.Size.Z, 12, 1);
                        break;

                    case Entity.InternalLocation.LocaionShapes.YCylinder:
                        GL.Rotate(90.0f, Vector3.UnitX);
                        Glu.Cylinder(quadric, loc.Size.X, loc.Size.Y, loc.Size.Z, 12, 1);
                        break;

                    case Entity.InternalLocation.LocaionShapes.XCylinder:
                        GL.Rotate(90.0f, Vector3.UnitY);
                        Glu.Cylinder(quadric, loc.Size.X, loc.Size.Y, loc.Size.Z, 12, 1);
                        break;
                }

                GL.PopMatrix();

                GL.LineWidth(1);
            }
        }
    }
}
