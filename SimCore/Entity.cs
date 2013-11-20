using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace SimCore
{
    public class Entity
    {
        UInt64 ID = UInt64.MinValue;

        public string Name = string.Empty;
        public Vector3d Location = Vector3d.Zero;
        public Vector2d Orientation = Vector2d.Zero;
        public double Speed = 0;
        public double Radius = 0;

        public class InternalLocation
        {
            public int Index = -1;
            public string Name = string.Empty;
            public double Size = 0;

            public List<int> Connections = new List<int>(); 
        }

        public List<InternalLocation> Locations = new List<InternalLocation>();
    }
}
