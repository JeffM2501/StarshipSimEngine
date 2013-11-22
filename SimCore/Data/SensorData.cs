using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore.Data
{
    public class LifeSignData
    {
        public enum LifeTypes
        {
            Unknown = 0,
            Humanoid,
            Vegatative,
            Aquatic,
            Self
        }

        public class Info
        {
            public UInt64 Count = UInt64.MinValue;
            public LifeTypes LifeType = LifeTypes.Unknown;
            public UInt16 Intelegence = 0;
        }

        public Dictionary<LifeTypes, Info> LifeSigns = new Dictionary<LifeTypes, Info>();
    }
}
