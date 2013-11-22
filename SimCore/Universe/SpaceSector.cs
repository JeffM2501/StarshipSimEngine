using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;

using SimCore.Entities;

namespace SimCore.Universe
{
    public class Sector
    {
        public UInt64 ID = UInt64.MaxValue;

        public Vector3d Size = Vector3d.Zero;
        public Vector3d GalacticOrign = Vector3d.Zero;

        public List<CelestialObject> Celestials = new List<CelestialObject>();
        public List<Entity> Vessels = new List<Entity>();
    }
}
