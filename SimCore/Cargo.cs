using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore
{
    public class Cargo : Actor
    {
        public enum CargoTypes
        {
            Unknown = 0,
            Water,
            Food,
            Oxygen,
            Fuel,
            Bomb,
            Torpedo,
            RepairParts,
        }

        public CargoTypes CargoType = CargoTypes.Unknown;
        public double Quantity = 0.0;
    }
}
