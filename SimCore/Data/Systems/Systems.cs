using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

using SimCore.Actors;
using SimCore.Entities;

namespace SimCore.Data.Systems
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

        public UInt64 ControlComputer = UInt64.MaxValue;
    }

    public class ComputerSystem : BaseSystem
    {
        public enum ComputerTypes
        {
            Unknown = 0,
            Drive,
            Science,
            Communications,
            Medical,
            Fire,
        }
        public ComputerTypes ComputerType = ComputerTypes.Unknown;

        public double ComputationFactor = 0;
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
