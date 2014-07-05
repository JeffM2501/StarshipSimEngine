using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore.Data.Systems
{
    public class DefensiveSystem : BaseSystem
    {
        public enum DefensiveTypes
        {
            None = 0,
            Screens,
            Shields,
            Cloaking,
        }
        public DefensiveTypes DefensiveType = DefensiveTypes.None;

        public virtual double AbsorbDamage(double damage) { return damage; }
        public virtual double ReflectSensorSignal (SensorSystem.SensorSystemType sensorType, double power) { return power; }
    }

    public class ScreenSystem : DefensiveSystem
    {
        public double NominalDamageReductionFactor = 0;
        public double AbsorbtionChargeReduction = 0;
    }

    public class ShieldSystem : DefensiveSystem
    {
        public double NominalAbsorpton = 0;
        public double AbsorptionChargeDecay = 0;
    }
}
