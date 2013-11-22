using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimCore.Entities;
using SimCore.Actors;

namespace SimCore.Data.Systems
{
    public class StorageSystem : BaseSystem
    {
        public enum StorageSystemTypes
        {
            Unkown = 0,
            Cargo,
            Personell,
            Prisoners,
            Torpedoes,
        }

        public StorageSystemTypes SystemType = StorageSystemTypes.Unkown;
        public double MaxCapacity = 0;

        public List<Actor> Contents = new List<Actor>();
    }

    public class DetentionSystem : StorageSystem
    {
        public float BaseBreakoutFactor = 0;
        public float BaseBreakoutDetectionFactor = 0;
    }

    public class FluidTankSystem : BaseSystem
    {
        public FluidTypes TankType = FluidTypes.Unknown;
        public double FluidPurity = 1.0;

        public double MaxCapacity = 0;
        public double Quantity = 0;

        public double MaxFlowRate = 0;
    }

    public class HangarSystem : BaseSystem
    {
        public int MaxCapacity = 0;
        public StarShip.StarShipSizeClasses MaxShipClass = StarShip.StarShipSizeClasses.None;
        public List<StarShip> DockedShips = new List<StarShip>();
    }
}
