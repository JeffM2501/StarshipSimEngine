using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore
{
    public class DiplomaticInfo
    {
        public class TreatyInfo
        {
            public enum TreatyTypes
            {
                None = 0,
                Peace,
            }

            public TreatyTypes TreatyType = TreatyTypes.None;
            public UInt64 From = UInt64.MinValue;
            public UInt64 To = UInt64.MinValue;
        }

        public List<TreatyInfo> PendingTreaties = new List<TreatyInfo>();
    }
}
