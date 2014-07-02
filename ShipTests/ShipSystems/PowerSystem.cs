using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;
using System.Xml;

namespace ShipSystems
{
    public class PowerSystem : ShipSystem
    {
        public float MaxFuel = 1000f;
        public float CurrentFuel = 0;

        public float FuelPerPower = 0.001f;

        public float MaxFuelFlow = 0.5f;
        public float CurrentFuelFlow = 0;

        public float MinEfficency = 0.01f;

        public class Battery
        {
            public int ID = 0;
            public float MaxPower = 100;
            public float CurrentPower = 100;
            public float MaxDischarge = 10;
            public float MaxCharge = 0.1f;

            public float HeatPerCharge = 10;

            public bool Connected = true;

            public bool Charge = false;
            public float ChargeFactor = 1.0f;

            public bool NeedsCharge()
            {
                return Connected && Charge && CurrentPower < MaxPower;
            }

            public bool CanDischarge()
            {
                return Connected && !Charge & MaxPower > 0;
            }

            public float GetChargeAmmount( float time)
            {
                if (!NeedsCharge())
                    return 0;

                float chargeAmmount = ChargeFactor * MaxCharge * time;
                if (CurrentPower + chargeAmmount > MaxPower)
                    return MaxPower - CurrentPower;

                return chargeAmmount;
            }

            public float GetDischargeAmmount( float time)
            {
                if (!CanDischarge())
                    return 0;

                float dischargeAmmount = MaxDischarge * time;
                if (dischargeAmmount > CurrentPower)
                    return CurrentPower;

                return dischargeAmmount;
            }
        }

        public List<Battery> Batteries = new List<Battery>();

        [XmlIgnoreAttribute]
        public List<ShipSystem> ConnectedSystems = new List<ShipSystem>();

        public PowerSystem():base(){}

        private float PowerBuffer = 0;
        private float UnallocatedPower = 0;

        public float GetGeneratedPower()
        {
            return PowerBuffer;
        }

        public float GetUnallocatedPower()
        {
            return UnallocatedPower;
        }

        private void GeneratePower(float time)
        {
            PowerBuffer = 0;
            if (CurrentFuel <= 0)
                return;

            float fuelUsed = CurrentFuelFlow * time;
            if (fuelUsed > CurrentFuel)
                fuelUsed = CurrentFuel;

            float efficencyFactor = 1.0f - (CurrentTemp / NominalTemp);
            if (efficencyFactor <= 0)
                efficencyFactor = MinEfficency;

            PowerBuffer = FuelPerPower * fuelUsed * efficencyFactor;
            CurrentFuel -= fuelUsed;
        }

        public override void Update(float time)
        {
            GeneratePower(time);

            // compute our power needs
            float totalPowerNeeded = 0;
            foreach (ShipSystem system in ConnectedSystems)
                totalPowerNeeded = system.DesiredPower * time;

            foreach(Battery bat in Batteries)
                totalPowerNeeded += bat.GetChargeAmmount(time);

            // compute power we have available;

            float powerAvailable = PowerBuffer;
            foreach (Battery bat in Batteries)
                powerAvailable += bat.GetDischargeAmmount(time);

            float supplyFactpr = 1.0f;

            if (powerAvailable < totalPowerNeeded)
                supplyFactpr = powerAvailable / totalPowerNeeded;

            // power the systems
            foreach (ShipSystem system in ConnectedSystems)
                system.CurrentPower = system.DesiredPower * supplyFactpr;

            // charge the batteries
            foreach (Battery bat in Batteries)
                bat.CurrentPower += bat.GetChargeAmmount(time) * supplyFactpr;

            UnallocatedPower = PowerBuffer - (totalPowerNeeded * supplyFactpr);

            // use the power
            powerAvailable -= PowerBuffer; // buffer always goes first

            if (powerAvailable > 0) // some had to come from batteries
            {
                float totalDischarge = 0;
                foreach (Battery bat in Batteries)
                    totalDischarge += bat.GetDischargeAmmount(time);

                if (totalDischarge <= 0)
                    throw(new SystemException("Unable to account for power use"));

                foreach (Battery bat in Batteries)
                {
                    float maxDischarge = bat.GetDischargeAmmount(time);
                    float factor = maxDischarge / totalDischarge;      // weight it

                    bat.CurrentPower -= powerAvailable * factor;    // we may not have pull all that the bateries could give, so only pull what we used
                }
            }

            base.Update(time);
        }

    }
}
