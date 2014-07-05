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

    public class SystemThermalProperties
    {
        //Heat Generation
        public double HeatGeneration = 0.35;
        public double OverPowerHeatGeneration= 1.1;

        public double ActivationHeat = 0;

        //Automatic Cooling
        public double MountCooling = 0.125;

        //Coolant Flow
        public double MaxCoolantFlowRate = 100;
        public double CurrentCoolantFlowFactor = 0;
        public double DesiredCoolantFlowFactor = 0;

        public double CurrentCoolantFlowRate { get { return MaxCoolantFlowRate * CurrentCoolantFlowFactor; } }

        // Temperature
        public double NominalTemperature = 100;
        public double CurrentTemperature = 0;
    }

    public class SystemPowerProperties
    {
        public double MaxPowerDraw = 0;
        public double NominalPowerDraw = 0;
        public double MinPowerDraw = 0;

        public double CurrentPowerFactor = 0;
        public double DesiredPowerFactor = 0;

        public double CurrentPowerDraw { get { return NominalPowerDraw * CurrentPowerFactor; } }

        public double MaxPowerBuffer = -1;
        public double BufferedPower = 0;
        public double MaxBufferChargeRate = 0;
        public double CurrentBufferChargeFactor = 0;
    }

    public class ContainerProperties
    {
        public double MaxCapacity = 0;
        public double CurrentCapacity = 0;
    }

    public class BaseSystem
    {
        public UInt64 SystemID = UInt64.MaxValue;
        public string SystemName = string.Empty;

        public SystemStatusInfo Status = new SystemStatusInfo();
        public SystemStatusInfo PowerConnection = new SystemStatusInfo();

        public SystemThermalProperties ThermalInfo = new SystemThermalProperties();
        public SystemPowerProperties PowerInfo = new SystemPowerProperties();

        public bool Essential = false;

        public double BaseEfectivness = 1;

        public int LocationID = -1;
        public Vector3d SystemLocation = Vector3d.Zero;

        public UInt64 ControlComputer = UInt64.MaxValue;

        public override string ToString()
        {
            return SystemName;
        }

        public virtual void OnSystemsChanged(Entities.Entity entity) { }
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
            Navigation,

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

        public double NominalPowerGenerationFactor = 1;

        public class FuelConsumption
        {
            public double ConsumptionRate = 0;

            public ContainerProperties Conainer = new ContainerProperties();

            public FluidTypes FuelType = FluidTypes.Unknown;
            public List<UInt64> SupplySystems = new List<UInt64>();

            public override string ToString()
            {
                return FuelType.ToString();
            }
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
        public ContainerProperties Conainer = new ContainerProperties();
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
        public double NominalRange = 0;
        public double NominalBandwith = 0;
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

        public double NominalRange = 0;
        public double NominalScanTime = 0;
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
        public double NominalRange = 0;
        public double NominalTransportTime = 0;

        public ContainerProperties Capacity = new ContainerProperties();

        public double TransportStatusParamater = 0;

        public enum ContentTypes
        {
            Cargo = 0,
            Personell,
            Munitions,
        }
        public ContentTypes ContentType = ContentTypes.Cargo;

        public enum TransportModes
        {
            Offline = 0,
            Idle,
            Inbound,
            Outbound,
        }
        public TransportModes CurrentTransportMode = TransportModes.Offline;

        public UInt64 Target = 0;

        public List<Actor> Contents = new List<Actor>();
    }

    public class TractorBeamSystem : BaseSystem
    {
        public double NominalRange = 0;
        public double NominalForce = 0;

        public UInt64 AttachedItem = UInt64.MaxValue;
    }
}
