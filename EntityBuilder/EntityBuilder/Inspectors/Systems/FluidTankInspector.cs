using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Data;
using SimCore.Data.Systems;

using EntityBuilder.Inspectors;

namespace EntityBuilder.Inspectors.Systems
{
    public partial class FluidTankInspector : BaseSystemInspector
    {
        FluidTankSystem TheTank = new FluidTankSystem();

        public FluidTankInspector() : base()
        {
            InitializeComponent();

            foreach (FluidTypes fluid in Enum.GetValues(typeof(FluidTypes)))
                FluidType.Items.Add(fluid);
        }

        public override void Set(object item, SimCore.Entities.Entity ent)
        {
            base.Set(item, ent);
            TheTank = item as FluidTankSystem;

            if (TheTank == null)
                return;

            FluidType.SelectedItem = TheTank.TankType;
            MaxFlowRate.Value = (decimal)TheTank.MaxFlowRate;
            Capacity.Value = (decimal)TheTank.MaxCapacity;
            Quantity.Value = (decimal)TheTank.Quantity;
        }

        private void FluidType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheTank.TankType == (FluidTypes)FluidType.SelectedItem)
                return;

            TheTank.TankType = (FluidTypes)FluidType.SelectedItem;
            CallInfoChanged(TheTank);
        }

        private void MaxFlowRate_ValueChanged(object sender, EventArgs e)
        {
            if (TheTank.MaxFlowRate == (double)MaxFlowRate.Value)
                return;

            TheTank.MaxFlowRate = (double)MaxFlowRate.Value;
            CallInfoChanged(TheTank);
        }

        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            if (TheTank.Quantity == (double)Quantity.Value)
                return;

            TheTank.Quantity = (double)Quantity.Value;
            CallInfoChanged(TheTank);
        }

        private void Capacity_ValueChanged(object sender, EventArgs e)
        {
            if (TheTank.MaxCapacity == (double)Capacity.Value)
                return;

            TheTank.MaxCapacity = (double)Capacity.Value;
            CallInfoChanged(TheTank);
        }
    }
}
