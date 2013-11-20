using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore
{
    public class Univese
    {
        public class FactionRegon
        {
            public string Name = string.Empty;
            public List<SpaceSector> Sectors = new List<SpaceSector>();
        }

        public List<SpaceSector> Sectors = new List<SpaceSector>();
        public List<FactionRegon> FactionRegons = new List<FactionRegon>();
    }
}
