using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;

namespace SimCore
{
    public class Person
    {
        public string Name = string.Empty;
        public UInt16 Intelegence = 0;

        public enum Ranks
        {
            None = 0,
            ScienceOfficer,
            EngineeringOfficer,
            MedicalOfficer,
            ChiefMedicalOfficer,
            SecurityOfficer,
            MaintenanceCrew,
            GeneralGrew,
        }
        public Ranks Rank = Ranks.None;

        public class LocationInfo
        {
            public UInt64 Host = UInt64.MinValue;
            public int Index = -1;
            public Vector3d Postion = Vector3d.Zero;
        }

        public LocationInfo CurrentLocation = new LocationInfo();
        public LocationInfo TargetLocation = null;
    }
}
