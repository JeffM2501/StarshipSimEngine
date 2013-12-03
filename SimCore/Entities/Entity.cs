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

        // the entity that we are attached to, ether physically like a moon to a planet
        // or operationally like a shuttle to a ship 
        public UInt64 ParrentID = UInt64.MaxValue;

        // the highest systemID used on this item
        public UInt64 LastSystemID = UInt64.MinValue;

        protected Dictionary<UInt64, BaseSystem> SystemCache = null;

        public BaseSystem[] GetSystemList()
        {
            if (SystemCache == null)
                RebuildSystemCache();

            return SystemCache.Values.ToArray();
        }

        public void RebuildSystemCache()
        {
            SystemCache = new Dictionary<UInt64, BaseSystem>();

            AddSystemsToCache(Engines);
            AddSystemsToCache(StorageSystems);
            AddSystemsToCache(PropulsionSystems); 
            AddSystemsToCache(NavigationSystems);
            AddSystemsToCache(DefensiveSystems);
            AddSystemsToCache(OffensiveSystems);
            AddSystemsToCache(MedicalSystems);
            AddSystemsToCache(LifeSupportDistrobutions);
            AddSystemsToCache(LifeSupportRecyclers);
            AddSystemsToCache(Hangars);
            AddSystemsToCache(Communications);
            AddSystemsToCache(Sensors);
            AddSystemsToCache(Transporters);
            AddSystemsToCache(TractorBeams);
            AddSystemsToCache(Computers);
        }

        protected void AddSystemsToCache(IEnumerable<BaseSystem> systems)
        {
            foreach (BaseSystem sys in systems)
                SystemCache.Add(sys.SystemID,sys);
        }

        protected bool AddSystemIfTypeMatch<T>(List<T> list, BaseSystem system) where T : BaseSystem
        {
            T s = system as T;

            if (s == null)
                return false;

            list.Add(s);
            SystemCache.Add(system.SystemID, system);
            return true;
        }

        protected void RemoveSystemIfExists<T>(List<T> list, BaseSystem system) where T : BaseSystem
        {
            if (system as T != null && list.Contains(system))
                list.Remove(system as T);
        }

        public void RemoveSystem(BaseSystem system) 
        {
            RemoveSystemIfExists<GenerationSystem>(Engines, system);
            RemoveSystemIfExists<StorageSystem>(StorageSystems, system);
            RemoveSystemIfExists<FluidTankSystem>(FluidTanks, system);
            RemoveSystemIfExists<PropulsionSystem>(PropulsionSystems, system);
            RemoveSystemIfExists<NavigationSystem>(NavigationSystems, system);
            RemoveSystemIfExists<DefensiveSystem>(DefensiveSystems, system);
            RemoveSystemIfExists<OffensiveSystem>(OffensiveSystems, system);
            RemoveSystemIfExists<MedicalSystem>(MedicalSystems, system);
            RemoveSystemIfExists<LifeSupportDistrobutionSystem>(LifeSupportDistrobutions, system);
            RemoveSystemIfExists<LifeSupportRecycleSystem>(LifeSupportRecyclers, system);
            RemoveSystemIfExists<HangarSystem>(Hangars, system);
            RemoveSystemIfExists<CommunicationSystem>(Communications, system);
            RemoveSystemIfExists<SensorSystem>(Sensors, system); 
            RemoveSystemIfExists<TransporterSystem>(Transporters, system);  
            RemoveSystemIfExists<TractorBeamSystem>(TractorBeams, system);
            RemoveSystemIfExists<ComputerSystem>(Computers, system);
                
            if (SystemCache.ContainsKey(system.SystemID))
                SystemCache.Remove(system.SystemID);
        }

        public void AddSystem(BaseSystem system)
        {
            if (GetSystemList().Contains(system))
                return;

            system.SystemID = LastSystemID;
            LastSystemID++;

            if (AddSystemIfTypeMatch<GenerationSystem>(Engines,system))
                return;
            else if (AddSystemIfTypeMatch<StorageSystem>(StorageSystems, system))
                return;
            else if (AddSystemIfTypeMatch<FluidTankSystem>(FluidTanks, system))
                return;
            else if (AddSystemIfTypeMatch<PropulsionSystem>(PropulsionSystems, system))
                return;
            else if (AddSystemIfTypeMatch<NavigationSystem>(NavigationSystems, system))
                return;
            else if (AddSystemIfTypeMatch<DefensiveSystem>(DefensiveSystems, system))
                return;
            else if (AddSystemIfTypeMatch<OffensiveSystem>(OffensiveSystems, system))
                return;
            else if (AddSystemIfTypeMatch<MedicalSystem>(MedicalSystems, system))
                return;
            else if (AddSystemIfTypeMatch<LifeSupportDistrobutionSystem>(LifeSupportDistrobutions, system))
                return;
            else if (AddSystemIfTypeMatch<LifeSupportRecycleSystem>(LifeSupportRecyclers, system))
                return;
            else if (AddSystemIfTypeMatch<HangarSystem>(Hangars, system))
                return;
            else if (AddSystemIfTypeMatch<CommunicationSystem>(Communications, system))
                return;
            else if (AddSystemIfTypeMatch<SensorSystem>(Sensors, system))
                return;
            else if (AddSystemIfTypeMatch<TransporterSystem>(Transporters, system))
                return;
            else if (AddSystemIfTypeMatch<TractorBeamSystem>(TractorBeams, system))
                return;
            else if (AddSystemIfTypeMatch<ComputerSystem>(Computers, system))
                return;


            // system is unknown, do something?
        }

    }
}
