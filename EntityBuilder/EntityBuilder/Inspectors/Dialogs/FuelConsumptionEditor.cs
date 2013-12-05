using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Data;
using SimCore.Data.Systems;

using SimCore.Entities;

namespace EntityBuilder.Inspectors.Dialogs
{
    public partial class FuelConsumptionEditor : Form
    {
        public FuelConsumptionEditor()
        {
            InitializeComponent();

             foreach (FluidTypes fluid in Enum.GetValues(typeof(FluidTypes)))
                FluidType.Items.Add(fluid);
        }

        public bool IsByproduct = false;

        public GenerationSystem.FuelConsumption Fuel = null;
        public Entity TheEntity = null;

        private void OK_Click(object sender, EventArgs e)
        {

            Fuel.FuelType = (FluidTypes)FluidType.SelectedItem;
            Fuel.Capacity = (double)Capacity.Value;
            Fuel.Quantity = (double)Efficency.Value;
            Fuel.ConsumptionRate = (double)ConsumptionRate.Value;

            Fuel.SupplySystems.Clear();
            foreach (FluidTankSystem tank in FuelList.Items)
            {
                if (tank.TankType == Fuel.FuelType)
                    Fuel.SupplySystems.Add(tank.SystemID);
            }
        }
           
        private void FuelConsumptionEditor_Load(object sender, EventArgs e)
        {
            this.Text = (IsByproduct ? "Byproduct Generation" : "Fuel Consumption" );

            if (Fuel == null || TheEntity == null)
                return;

            FluidType.SelectedItem = Fuel.FuelType;

            ConsumptionRate.Value = (decimal)Fuel.ConsumptionRate;
            Efficency.Value = (decimal)Fuel.Quantity;
            Capacity.Value = (decimal)Fuel.Capacity;

            foreach (UInt64 tank in Fuel.SupplySystems)
            {
                FluidTankSystem system = TheEntity.GetSystemByID(tank) as FluidTankSystem;
                if (system == null)
                    return;

                FuelList.Items.Add(system);
            }

            TankList.Items.AddRange(TheEntity.FluidTanks.ToArray());

            if (TankList.Items.Count > 0)
                TankList.SelectedIndex = 0;

            FuelList_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void AddTank_Click(object sender, EventArgs e)
        {
            if (TankList.Items.Count == 0 || FuelList.Items.Contains(TankList.SelectedItem))
                return;

            FuelList.Items.Add(TankList.SelectedItem);
        }

        private void RemoveTank_Click(object sender, EventArgs e)
        {
            TankList.Items.Remove(TankList.SelectedItem);
            TankList.SelectedIndex = -1;
        }

        private void FuelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveTank.Enabled = FuelList.SelectedIndex >= 0;
        }
    }
}
