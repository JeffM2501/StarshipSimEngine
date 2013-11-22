using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;

using SimCore.Data;

namespace SimCore.Actors
{
    public class Actor
    {
        public string Name = string.Empty;
        public double Mass = 0.0;

        public class LocationInfo
        {
            public UInt64 Host = UInt64.MinValue;
            public int TargetLocationIndex = -1;
            public Vector3d Postion = Vector3d.Zero;
        }

        public LocationInfo CurrentLocation = new LocationInfo();
        public LocationInfo TargetLocation = null;
    }

    public class Person : Actor
    {
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

        public double HealthStatus = 1.0;
        public double FunctionalSatus = 1.0;

        public double FoodPerServing = 1;
        public double FoodServingCycle = 1.0 / 3.0;

        public double WaterPerServing = 0.1;
        public double WaterServingCycle = 1.0 / 8.0;

        public double OxygenConsumption = 1.0;

        public double CarryingCapacity = 0.0;

        public List<Equipment> CariedEquipment = new List<Equipment>();
    }
}
