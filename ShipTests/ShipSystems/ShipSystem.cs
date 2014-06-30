using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipSystems
{
    public class ShipSystem
    {
        public string SystemName = string.Empty;
        
        public float HeatGeneratedPerSecondPerPower = 0.35f;
        public float OverPowerHeatFactor = 1.1f;

        public float ActivationHeat = 0;

        public float NominalTemp = 100;
        public float CurrentTemp = 0;

        public float NominalPower = 100;
        public float MaxPower = 300;
        public float CurrentPower = 0;
        public float DesiredPower = 0;

        public float MaxCoolantFlow = 100;
        public float EfectiveCoolantFlowFactor = 0;
        public float DesiredCoolantFlow = 0;

        public bool Essential = false;
        public float MinimumPower = 0;

        public float AmbientCooling = 0.125f;

        public float CurrentCoolantFlow
        {
            get { return DesiredCoolantFlow * EfectiveCoolantFlowFactor; }
        }

        public float HeatDamageFactor = 0.001f; // per second per degree over nominal
        public float Damage = 0;

        public ShipSystem() { }

        public ShipSystem(string name)
        {
            SystemName = name;
        }

        public ShipSystem(string name, bool essential, float minPower)
        {
            SystemName = name;
            Essential = essential;
            MinimumPower = minPower;
            if (essential)
                SetDesiredPower(MinimumPower);
        }

        public virtual void Activate()
        {
            CurrentTemp += ActivationHeat;
        }

        public virtual void UpdateDamage(float time)
        {
            if (CurrentTemp > NominalTemp)
            {
                float overheat = CurrentTemp - NominalTemp;
                float heatDamage = overheat * HeatDamageFactor;

                float damageMultiplyer = 1;
                if (Damage > 0)
                    damageMultiplyer = 1/(1-Damage);

                Damage += heatDamage * damageMultiplyer * time;
            }
        }

        public virtual void Update(float time)
        {
            UpdateDamage(time);
        }

        public virtual void SetDesiredPower(float value)
        {
            DesiredPower = value;
            if (DesiredPower < MinimumPower)
                DesiredPower = MinimumPower;

            if (DesiredPower > MaxPower)
                DesiredPower = MaxPower;

            // TODO, let the ship set this based on power available
            CurrentPower = DesiredPower;
        }
    }
}
