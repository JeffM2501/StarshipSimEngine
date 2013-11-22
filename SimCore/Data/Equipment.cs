using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore.Data
{
    public class Equipment
    {
        public UInt64 ID = UInt64.MaxValue;
        public string Name = string.Empty;

        public enum EquipmentEffectTypes
        {
            None = 0,
            IncreaseCarryCapacity,
            IncreaseHealthStatus,
        }

        public class EquipmentEffect
        {
            public EquipmentEffectTypes Effect = EquipmentEffectTypes.None;
            public double Value = 0.0;
        }

        public List<EquipmentEffect> Effects = new List<EquipmentEffect>();
    }
}
