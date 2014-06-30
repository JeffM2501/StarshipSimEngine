using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipSystems
{
    public class CoolantSystem : ShipSystem
    {
        public float MaxCoolant = 100;
        public float TotalCoolant = 100;

        public float NominalHeatTransfer = 1.5f;

        public float HeatSyncRemovalFactor = 3;

        public CoolantSystem() { }

        public class Reservoir
        {
            public int ID = 0;

            public float MaxCoolant = 0;
            public float TotalCoolant = 0;

            public float Temurature = 0;

            public bool Connected = false;

            public Reservoir() { }

            public Reservoir(float max)
            {
                MaxCoolant = max;
                TotalCoolant = max;
            }
        }

        public List<Reservoir> Reservoirs = new List<Reservoir>();

        public List<ShipSystem> ConnectedSystems = new List<ShipSystem>();

        public void AddReservoir(Reservoir reservoir)
        {
            reservoir.ID = Reservoirs.Count + 1;
            Reservoirs.Add(reservoir);
        }

        public float ComputeSystemTemp(ShipSystem system, float time)
        {
            float powerHeat = (system.CurrentPower * system.HeatGeneratedPerSecondPerPower * time);

            if (system.CurrentPower > system.NominalPower)
            {
                float extraHeat = (system.CurrentPower-system.NominalPower) * (system.HeatGeneratedPerSecondPerPower * system.OverPowerHeatFactor) * time;
                powerHeat += extraHeat;
            }

            powerHeat -= system.AmbientCooling * time;

            if (powerHeat < 0)
                powerHeat = 0;

            return system.CurrentTemp + powerHeat;
        }

        public float TotalCoolantInAction()
        {
            float total = TotalCoolant;
            foreach(Reservoir r in Reservoirs)
            {
                if (r.Connected)
                    total += r.TotalCoolant;
            }

            return total;
        }

        public float UnallocatedCoolant()
        {
            float usedCoolant = 0;
            foreach (ShipSystem system in ConnectedSystems)
                usedCoolant += system.CurrentCoolantFlow;

            return TotalCoolantInAction() - usedCoolant;
        }

        protected ShipSystem FindSystem(string name)
        {
            return ConnectedSystems.Find(delegate(ShipSystem s) { return s.SystemName == name; });
        }

        public float SetSystemCoolant(string systemName, float desiredCoolant)
        {
            return SetSystemCoolant(FindSystem(systemName), desiredCoolant);
        }

        public float SetSystemCoolant(ShipSystem system, float desiredCoolant)
        {
            if (system == null)
                return 0;

            float actualCoolant = desiredCoolant;
            if (actualCoolant > system.MaxCoolantFlow)
                actualCoolant = system.MaxCoolantFlow;

            system.DesiredCoolantFlow = actualCoolant;  // cap at he max
            return actualCoolant;
        }

        public float TransferFromReserveToSystem(Reservoir reservoir, float ammount)
        {
            if (reservoir == null || ammount < 0)
                return 0;

            float actualAmmount = ammount;
            if (actualAmmount > reservoir.TotalCoolant)
                actualAmmount = reservoir.TotalCoolant;

            if (actualAmmount + TotalCoolant > MaxCoolant)
                actualAmmount = MaxCoolant - TotalCoolant;

            if (!reservoir.Connected)// compute a new temp based on weighted average
                CurrentTemp = ((reservoir.Temurature * actualAmmount) + (CurrentTemp * TotalCoolant)) / (TotalCoolant + actualAmmount);

            reservoir.TotalCoolant -= actualAmmount;
            TotalCoolant += actualAmmount;

            return reservoir.TotalCoolant;
        }

        public float TransferFromSystemToReserve(Reservoir reservoir, float ammount)
        {
            if (reservoir == null || ammount < 0 || TotalCoolant <= 0)
                return 0;

            float actualAmmount = ammount;
            if (actualAmmount > TotalCoolant)
                actualAmmount = TotalCoolant;

            if (actualAmmount + reservoir.TotalCoolant > reservoir.MaxCoolant)
                actualAmmount = reservoir.MaxCoolant - reservoir.TotalCoolant;

            if (!reservoir.Connected)// compute a new temp based on weighted average
                reservoir.Temurature = ((CurrentTemp * actualAmmount) + (reservoir.Temurature * reservoir.TotalCoolant)) / (reservoir.TotalCoolant + actualAmmount);

            reservoir.TotalCoolant += actualAmmount;
            TotalCoolant-= actualAmmount;

            return reservoir.TotalCoolant;
        }

        public bool ConnectReserve(Reservoir reservoir)
        {
            if (reservoir == null || reservoir.Connected)
                return false;

            reservoir.Temurature = CurrentTemp = ((reservoir.Temurature * reservoir.TotalCoolant) + (CurrentTemp * TotalCoolant)) / (TotalCoolant + reservoir.TotalCoolant);
            reservoir.Connected = true;
            return true;
        }

        public bool DisconnectReserve(Reservoir reservoir)
        {
            if (reservoir == null || !reservoir.Connected)
                return false;

            reservoir.Connected = false;
            return true;
        }

        public bool FlushReserve(Reservoir reservoir)
        {
            if (reservoir == null || reservoir.TotalCoolant <= 0 || reservoir.Connected)
                return false;

            reservoir.Temurature = 0;
            reservoir.TotalCoolant = 0;
            return false;
        }

        public float RefillReserve(Reservoir reservoir, float amount) // assumes a flush of any hot coolant in the reserve
        {
            if (reservoir == null || reservoir.Connected)
                return 0;

            FlushReserve(reservoir);

            if (amount > reservoir.MaxCoolant)
                amount = reservoir.MaxCoolant;

            reservoir.TotalCoolant = amount;
            return reservoir.TotalCoolant;
        }

        protected void ComputeActualCoolantLevels()
        {
            float neededCoolant = 0;
            foreach (ShipSystem system in ConnectedSystems)
            {
                neededCoolant += system.DesiredCoolantFlow;
                system.EfectiveCoolantFlowFactor = 1;
            }
                
            float avalableCoolant = TotalCoolantInAction();

            if (neededCoolant > avalableCoolant)
            {
                // compute a factor
                float factor = avalableCoolant / neededCoolant;

                foreach (ShipSystem system in ConnectedSystems)
                    system.EfectiveCoolantFlowFactor = factor;
            }
        }

        public override void Update( float time)
        {
            float deltaTemp = 0;

            ComputeActualCoolantLevels();

            float coolantPool = TotalCoolantInAction() * 0.25f;

            foreach (ShipSystem system in ConnectedSystems)
            {
                if (system.DesiredCoolantFlow != system.CurrentCoolantFlow) // try to give them what they want
                    SetSystemCoolant(system, system.DesiredCoolantFlow);    // TODO, figure out how much desired but unallocated coolant systems needs and fill them proportionally
                
                float systemTemp = ComputeSystemTemp(system, time);

                if (system.CurrentCoolantFlow > 0)
                {
                    // how much heat can we remove from this system
                    float coolantEfficeny = 0;
                    if ( systemTemp > CurrentTemp)
                    {
                        float coolantToSystemTempDelta = systemTemp - CurrentTemp;
                        coolantEfficeny = coolantToSystemTempDelta / systemTemp;
                    }
                    
                    float heatRemoved = system.CurrentCoolantFlow * (NominalHeatTransfer*coolantEfficeny) * time;

                    if (heatRemoved > systemTemp)
                    {
                        heatRemoved = systemTemp;
                        systemTemp = 0;
                    }
                    else
                        systemTemp -= heatRemoved;

                    if (systemTemp < 0)
                        systemTemp = 0;
  
                    deltaTemp += heatRemoved / coolantPool; // spread it out over the coolant pool
                }
        
               system.CurrentTemp = systemTemp;
            }

            CurrentTemp += deltaTemp;

            // pull off what the heatsync can do
            float heatToRemove = HeatSyncRemovalFactor * time;

            if (heatToRemove < deltaTemp)
            {
                int i = 0;
            }

            if (heatToRemove > CurrentTemp)
                CurrentTemp = 0;
            else
                CurrentTemp -= heatToRemove;

            // all connected reserves get our temp
            foreach (Reservoir r in Reservoirs)
            {
                if (r.Connected)
                    r.Temurature = CurrentTemp;
            }

            base.Update(time);
        }
    }
}
