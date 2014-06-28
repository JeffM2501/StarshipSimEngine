using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipSystems
{
    public class ShipSystem
    {
        public string SystemName = string.Empty;
        
        public float HeatGeneratedPerSecondPerPower = 1;
        public float OverPowerHeatFactor = 2;

        public float ActivationHeat = 0;

        public float NominalTemp = 100;
        public float CurrentTemp = 0;

        public float NominalPower = 100;
        public float MaxPower = 300;
        public float CurrentPower = 0;

        public float MaxCoolantFlow = 0;
        public float CurrentCoolantFlow = 0;

        public float HeatDamageFactor = 0.001f; // per second per degree over nominal
        public float Damage = 0;

        public ShipSystem() { }

        public ShipSystem(string name)
        {
            SystemName = name;
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
    }
}
