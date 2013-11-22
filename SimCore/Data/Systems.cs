using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

using SimCore.Actors;
using SimCore.Entities;

namespace SimCore.Data
{
    public class SystemStatusInfo
    {
        public double OperationalStatus = 0;
        public double FunctionalStatus = 0;
        public double Reliability = 1.0;
    }

    public class BaseSystem
    {
        public UInt64 SystemID = UInt64.MaxValue;

        public SystemStatusInfo Status = new SystemStatusInfo();
        public SystemStatusInfo PowerConnection = new SystemStatusInfo();

        public double PowerConsumption = 0;

        public double MaxPowerBuffer = -1;
        public double BufferedPower = 0;
        public double MaxPowerDraw = 0;

        public double BaseEfectivness = 1;

        public int LocationID = -1;
    }

    public class GenerationSystem : BaseSystem
    {
        public enum GenerationTypes
        {
            Unknown = 0,
            Battery,
            Solar,
            Fusion,
            Fission,
            AntiMater,
            Combustion,
            Chemical,
            Exotic,
        }
        public GenerationTypes GenerationType = GenerationTypes.Unknown;

        public double PowerGeneration = 0;

        public class FuelConsumption
        {
            public double ConsumptionRate = 0;

            public double Capacity = 0;
            public double Quantity = 0;

            public FluidTypes FuelType = FluidTypes.Unknown;
            public List<int> SupplySystems = new List<int>();
        }

        public List<FuelConsumption> FuelConsumptions = new List<FuelConsumption>();
        public List<FuelConsumption> Byproducts = new List<FuelConsumption>();
    }

    public class DefensiveSystem : BaseSystem
    {
        public enum DefensiveTypes
        {
            None = 0,
            Screens,
            Shields,
            Cloaking,
        }
        public DefensiveTypes DefensiveType = DefensiveTypes.None;

        public double Efficiency = 0;
    }

    public class OffensiveSystem : BaseSystem
    {
        public enum OffensiveTypes
        {
            None = 0,
            Phasers,
            Torpedoes,
        }

        public OffensiveTypes OffensiveType = OffensiveTypes.None;

        public Vector3d Orientation = Vector3d.UnitX;
        public double Arc = 0;

        public double Buffer = 0;
    }

    public class PropulsionSystem : BaseSystem
    {
        public enum PropulsionTypes
        {
            None = 0,
            Impulse,
            Warp,
            Reaction,
        }
        public PropulsionTypes PropulsionType = PropulsionTypes.None;

        public double BaseThrust = 1.0;

        public List<GenerationSystem.FuelConsumption> FuelConsumptions = new List<GenerationSystem.FuelConsumption>();
    }

    public class MedicalSystem : BaseSystem
    {
        public enum MedicalSystemTypes
        {
            Unkown = 0,
            Research,
            IntensiveCare,
            Computer,
            Stores,
        }

        public MedicalSystemTypes SystemType = MedicalSystemTypes.Unkown;
        public double Capacity = 0;
        public double Quantity = 0;
    }

    public class StorageSystem : BaseSystem
    {
        public enum StorageSystemTypes
        {
            Unkown = 0,
            Cargo,
            Personell,
            Prisoners,
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

    public class LifeSupportSystem : BaseSystem
    {
        public enum LifeSupportTypes
        {
            Unkown = 0,
            Oxygen,
            Water,
            Food,
        }
        public LifeSupportTypes SystemType = LifeSupportTypes.Unkown;
        public List<UInt64> StorageSystesm = new List<UInt64>();

        public double QualityChangeFactor = 1.0;
    }

    public class LifeSupportDistrobutionSystem : LifeSupportSystem
    {
        public double MaxFlow = 0;
    }

    public class LifeSupportRecycleSystem : LifeSupportSystem
    {
        public double Efficency = 1;
    }

    public class HangarSystem : BaseSystem
    {
        public int MaxCapacity = 0;
        public StarShip.StarShipSizeClasses MaxShipClass = StarShip.StarShipSizeClasses.None;
        public List<StarShip> DockedShips = new List<StarShip>();
    }

    public class CommunicationSystem : BaseSystem
    {
        public double MaxRange = 0;
        public double MaxBandwith = 0;
    }

    public class SensorSystem : BaseSystem
    {
        public enum SensorSystemType
        {
            Unkown = 0,
            Spatial,
            Radition,
            Gravity,
            Life,
            Material,
        }
        public SensorSystemType SensorType = SensorSystemType.Unkown;

        public double MaxRange = 0;
        public double BaseScanTime = 0;
    }

    public class NavigationSystem : BaseSystem
    {
        public enum NavigationSystemType
        {
            Unkown = 0,
            Computer,
        }
        public NavigationSystemType NavigationType = NavigationSystemType.Unkown;
    }

    public class TransporterSystem : BaseSystem
    {
        public double MaxRange = 0;
        public double TransportTime = 0;
        public double MassCapacity = 0;

        public double TransportStatusParamater = 0;

        public enum ContentTypes
        {
            Cargo = 0,
            Personell,
        }
        public ContentTypes ContentType = ContentTypes.Cargo;
        public List<Actor> Contents = new List<Actor>();
    }

    public class TractorBeamSystem : BaseSystem
    {
        public double MaxRange = 0;
        public double MaxForce = 0;

        public UInt64 AttachedItem = UInt64.MaxValue;
    }
}
