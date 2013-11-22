using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

using SimCore.Data;

namespace SimCore.Entities
{
    public class SimulationObject
    {
        public UInt64 ID = UInt64.MaxValue;
        public virtual void Think(double time, double delta) { }
    }

    public class Entity : SimulationObject
    {
        public string Name = string.Empty;
        public Vector3d Location = Vector3d.Zero;
        public Vector2d Orientation = Vector2d.Zero;
        public double Speed = 0;
        public double Radius = 0;

        public class InternalLocation
        {
            public int Index = -1;
            public string Name = string.Empty;
            public double Size = 0;

            public List<int> Connections = new List<int>(); 
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

        public DiplomaticInfo Diplomatics = new DiplomaticInfo();

    }
}
