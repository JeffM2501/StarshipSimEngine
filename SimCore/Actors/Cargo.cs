using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimCore.Data;

namespace SimCore.Actors
{
    public class Cargo : Actor
    {
        public enum CargoTypes
        {
            Unknown = 0,
            Fluid,
            Bulk,
            Torpedo,
            RepairParts,
            MedicalSupplies,
        }

        public CargoTypes CargoType = CargoTypes.Unknown;
        public double Quantity = 0.0;
    }

    public class FluidCargo : Cargo
    {
        public FluidTypes FluidType = FluidTypes.Unknown;
        public double FluidPurity = 1;
    }

    public class BulkCargo : Cargo
    {
        public BulkMaterialTypes MaterialType = BulkMaterialTypes.Unkown;
        public double MaterialQuality = 1.0;
    }
}
