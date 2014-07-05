using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimCore.Entities;
using SimCore.Actors;
using SimCore.Data;

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
            Equipment,
        }

        public StorageSystemTypes SystemType = StorageSystemTypes.Unkown;
        public double MaxCapacity = 0;

        public List<Actor> Contents = new List<Actor>();
        public List<Equipment> EquipmentStores = new List<Equipment>();

        public virtual Actor AcceptActor(Actor actor)
        {
            switch (SystemType) // only store the right kind of thing
            {
                case StorageSystemTypes.Cargo:
                    if (actor as Cargo != null)
                    {
                        Contents.Add(actor);
                        actor = null;
                    }
                    break;

                case StorageSystemTypes.Personell:
                    if (actor as Person != null)
                    {
                        Contents.Add(actor);
                        actor = null;
                    }
                    break;

                case StorageSystemTypes.Prisoners:
                    if (actor as Person != null)
                    {
                        // prisoners can't have gear
                        Person person = actor as Person;
                        EquipmentStores.AddRange(person.CariedEquipment);
                        person.CariedEquipment.Clear();

                        Contents.Add(actor);
                        actor = null;
                    }
                    break;

                case StorageSystemTypes.Torpedoes:
                    if (actor as Torpedo != null)
                    {
                        Contents.Add(actor);
                        actor = null;
                    }
                    break;              
            }
            if (actor != null)
            {
                Cargo cargo = actor as Cargo;

                if (cargo != null)
                {
                    if (cargo.CargoType == Cargo.CargoTypes.Equipment)
                    {
                        EquipmentStores.AddRange((cargo as EquipmentCargo).Contents);
                        actor = null;
                    }
                }
            }
            
            return actor;
        }
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

        public ContainerProperties Contents = new ContainerProperties();

        public double NominalFlowRate = 0;
    }

    public class ResevoirSystem : FluidTankSystem
    {
        public bool Connected = false;
    }

    public class HeatSinkSystem : BaseSystem
    {
        public double NominalTemperatureRemoved = 2.5;
    }

    public class CoolantSystem : ResevoirSystem
    {
        public List<UInt64> Resevoirs = new List<UInt64>();
        public List<UInt64> HeatSinks = new List<UInt64>();

        protected List<ResevoirSystem> ResevoirsCache = new List<ResevoirSystem>();
        protected List<HeatSinkSystem> HeatSinkCache = new List<HeatSinkSystem>();

        public double NominalHeatTrasnfer = 1.5;

        public override void OnSystemsChanged(Entity entity)
        {
            ResevoirsCache = entity.FindSystemsOfTypeByIDs<ResevoirSystem>(Resevoirs);
            HeatSinkCache = entity.FindSystemsOfTypeByIDs<HeatSinkSystem>(HeatSinks);
        }
    }

    public class HangarSystem : BaseSystem
    {
        public int MaxCapacity = 0;
        public StarShip.StarShipSizeClasses MaxShipClass = StarShip.StarShipSizeClasses.None;
        public List<StarShip> DockedShips = new List<StarShip>();

        public class ServiceCraftInfo
        {
            public StarShip Craft = null;

            public enum Dispostions
            {
                Docked,
                OnMission,
                Missing,
                Maintenance,
            }

            public Dispostions Disposition = Dispostions.Missing;
        }

        public List<ServiceCraftInfo> ServiceCraft = new List<ServiceCraftInfo>();
    }
}
