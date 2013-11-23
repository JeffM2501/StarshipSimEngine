using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore.Universe
{
    public class Faction
    {
        public string Name = string.Empty;
        public string Initals = string.Empty;
        public string ShortName = string.Empty;
        public string ShipPrefix = string.Empty;

        public UInt64 ID = UInt64.MaxValue;

        public class SectorInfluence
        {
            public bool CoreWorld = false;
            public UInt64 SectorID = UInt64.MaxValue;
            public double InfluenceFactor = 0;
        }

        public List<SectorInfluence> InfluencedSectors = new List<SectorInfluence>();

        public enum GovernmentTypes
        {
            Unknown = 0,
            Democracy,
            Empire,
            Monarchy,
            Dictatorship,
            Collective,
            Republic,
            Alliance,
            Hive,
        }

        public GovernmentTypes GovermentType = GovernmentTypes.Unknown;

        public enum InteractionTypes
        {
            Unknown = 0,
            Ambivolent,
            Aggressive,
            Submissive,
            Suportive,
            Subversive,
            Defensive,
            Assult,
            Altruistic,
            Xenophobic,
        }

        public class InteractionInfo
        {       
            public UInt64 FactionID = UInt64.MaxValue;
            public InteractionTypes Interaction = InteractionTypes.Unknown;
        }

        public List<InteractionInfo> Interactions = new List<InteractionInfo>();

        public InteractionTypes DefaultInteractionType = InteractionTypes.Unknown;
    }
}
