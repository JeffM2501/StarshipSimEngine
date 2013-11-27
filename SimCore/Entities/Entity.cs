using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;

using SimCore.Data;
using SimCore.Data.Systems;
using SimCore.Actors;

namespace SimCore.Entities
{
    public class SimulationObject
    {
        public UInt64 ID = UInt64.MaxValue;
        public virtual void Think(double time, double delta) { }
    }

    public class Entity : SimulationObject
    {
        public enum EntityTypes
        {
            Unkown,
            Celestial,
            Ship,
            Station,
        }
        public EntityTypes EntityType = EntityTypes.Unkown;


        public string Name = string.Empty;
        public Vector3d Location = Vector3d.Zero;
        public Vector2d Orientation = Vector2d.Zero;

        public double RelativisticSpeed = 0;
        public double FTLSpeed = 0;

        public double Radius = 0;

        public class InternalLocation
        {
            public int Index = -1;
            public string Name = string.Empty;

            public Vector3d Origin = Vector3d.Zero;
            public Quaterniond Orientation = new Quaterniond(0,0,1,0);

            public enum LocaionShapes
            {
                Rectangular,
                XCylinder,
                YCylinder,
                ZCylinder,
                Sphere,
            }
            public LocaionShapes Shape = LocaionShapes.Rectangular;
            
            // Size varies by shape
            // Rectangle, H, V, D
            // Cylinders, Radius, Length, Segment Size (0 = full)
            // Sphere, Radius, Unused, Unused
            public Vector3d Size = new Vector3d(1,1,1);

            public double TraversalSpeed = 0;

            public class ConnectionInfo
            {
                public int TargetIndex = -1;
                public Vector3d ConnectionPoint = Vector3d.Zero;
            }
            public List<ConnectionInfo> Connections = new List<ConnectionInfo>();

            public class StationInformation
            {
                public string Name = string.Empty;
                public double Condition = 1.0;
                public Person Crewmember = null;
            }
            public List<StationInformation> Stations = new List<StationInformation>();

            public override string ToString()
            {
                return Name;
            }
        }

        public List<InternalLocation> Locations = new List<InternalLocation>();

        public List<GenerationSystem> Engines = new List<GenerationSystem>();
        public List<StorageSystem> StorageSystems = new List<StorageSystem>();
        public List<FluidTankSystem> FluidTanks = new List<FluidTankSystem>();

        public List<PropulsionSystem> PropulsionSystems = new List<PropulsionSystem>(); 
        public List<NavigationSystem> NavigationSystems = new List<NavigationSystem>();

        public List<DefensiveSystem> DefensiveSystems = new List<DefensiveSystem>();
        public List<OffensiveSystem> OffensiveSystems = new List<OffensiveSystem>();

        public List<MedicalSystem> MedicalSystems = new List<MedicalSystem>();

        public List<LifeSupportDistrobutionSystem> LifeSupportDistrobutions = new List<LifeSupportDistrobutionSystem>();
        public List<LifeSupportRecycleSystem> LifeSupportRecyclers = new List<LifeSupportRecycleSystem>();

        public List<HangarSystem> Hangars = new List<HangarSystem>();

        public List<CommunicationSystem> Communications = new List<CommunicationSystem>();

        public List<SensorSystem> Sensors = new List<SensorSystem>();

        public List<TransporterSystem> Transporters = new List<TransporterSystem>();

        public List<TractorBeamSystem> TractorBeams = new List<TractorBeamSystem>();

        public List<ComputerSystem> Computers = new List<ComputerSystem>();

        public DiplomaticInfo Diplomatics = new DiplomaticInfo();

    }
}
