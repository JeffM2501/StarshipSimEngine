using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EntityBuilder.Inspectors;
using EntityBuilder.Inspectors.Dialogs;

using SimCore.Data.Systems;


namespace EntityBuilder.Inspectors.Systems
{
    public partial class GeneratorInspector : BaseSystemInspector
    {
        GenerationSystem TheGenerator = null;

        public GeneratorInspector() : base()
        {
            InitializeComponent();
        }

        public override void Set(object item, SimCore.Entities.Entity ent)
        {
            base.Set(item, ent);
            TheGenerator = item as GenerationSystem;

            if (TheGenerator == null)
                return;

            foreach (GenerationSystem.GenerationTypes genType in Enum.GetValues(typeof(GenerationSystem.GenerationTypes)))
                GeneratorType.Items.Add(genType);

            GeneratorType.SelectedItem = TheGenerator.GenerationType;

            PowerGeneration.Value = (decimal)TheGenerator.PowerGeneration;

            FuelList.Items.Clear();
            ByproductList.Items.Clear();

            foreach (GenerationSystem.FuelConsumption fuel in TheGenerator.FuelConsumptions)
                FuelList.Items.Add(fuel);

            foreach (GenerationSystem.FuelConsumption byproduct in TheGenerator.Byproducts)
                ByproductList.Items.Add(byproduct);
        }

        private void GeneratorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheGenerator.GenerationType == ((GenerationSystem.GenerationTypes)GeneratorType.SelectedItem))
                return;

            TheGenerator.GenerationType = (GenerationSystem.GenerationTypes)GeneratorType.SelectedItem;
            CallInfoChanged(TheGenerator);
        }

        private void PowerGeneration_ValueChanged(object sender, EventArgs e)
        {
            if (TheGenerator.PowerGeneration == (double)PowerGeneration.Value)
                return;

            TheGenerator.PowerGeneration = (double)PowerGeneration.Value;
            CallInfoChanged(TheGenerator);
        }

        private void AddFuel_Click(object sender, EventArgs e)
        {
            FuelConsumptionEditor editor = new FuelConsumptionEditor();
            editor.Fuel = new GenerationSystem.FuelConsumption();
            editor.TheEntity = TheEntity;

            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                TheGenerator.FuelConsumptions.Add(editor.Fuel);
                FuelList.Items.Add(editor.Fuel);
                CallInfoChanged(TheGenerator);
            }
        }

        private void RemoveFuel_Click(object sender, EventArgs e)
        {
            if (FuelList.SelectedIndex == -1)
                return;

            TheGenerator.FuelConsumptions.RemoveAt(FuelList.SelectedIndex);
            FuelList.Items.Add(FuelList.SelectedItem);
            CallInfoChanged(TheGenerator);
        }

        private void EditFuel_Click(object sender, EventArgs e)
        {
            FuelConsumptionEditor editor = new FuelConsumptionEditor();
            editor.Fuel = FuelList.SelectedItem as GenerationSystem.FuelConsumption;
            editor.TheEntity = TheEntity;

            if (editor.ShowDialog(this) == DialogResult.OK)
                CallInfoChanged(TheGenerator);
        }

        private void AddByproduct_Click(object sender, EventArgs e)
        {
            FuelConsumptionEditor editor = new FuelConsumptionEditor();
            editor.IsByproduct = true;
            editor.Fuel = new GenerationSystem.FuelConsumption();
            editor.TheEntity = TheEntity;

            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                TheGenerator.Byproducts.Add(editor.Fuel);
                ByproductList.Items.Add(editor.Fuel);
                CallInfoChanged(TheGenerator);
            }
        }

        private void RemoveByproduct_Click(object sender, EventArgs e)
        {
            if (FuelList.SelectedIndex == -1)
                return;

            TheGenerator.Byproducts.RemoveAt(ByproductList.SelectedIndex);
            ByproductList.Items.Add(ByproductList.SelectedItem);
            CallInfoChanged(TheGenerator);
        }

        private void EditByproduct_Click(object sender, EventArgs e)
        {
            FuelConsumptionEditor editor = new FuelConsumptionEditor();
            editor.IsByproduct = true;
            editor.Fuel = ByproductList.SelectedItem as GenerationSystem.FuelConsumption;
            editor.TheEntity = TheEntity;

            if (editor.ShowDialog(this) == DialogResult.OK)
                CallInfoChanged(TheGenerator);
        }
    }
}
