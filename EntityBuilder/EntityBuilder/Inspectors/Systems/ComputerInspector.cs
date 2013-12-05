using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EntityBuilder.Inspectors;
using SimCore.Data.Systems;

namespace EntityBuilder.Inspectors.Systems
{
    public partial class ComputerInspector : BaseSystemInspector
    {
        ComputerSystem TheComputer = null;

        public ComputerInspector() : base()
        {
            InitializeComponent();
        }

        public override void Set(object item, SimCore.Entities.Entity ent)
        {
            base.Set(item, ent);
            TheComputer = item as ComputerSystem;
            
            if (TheComputer == null)
                return;

            foreach (ComputerSystem.ComputerTypes compType in Enum.GetValues(typeof(ComputerSystem.ComputerTypes)))
                ComputerType.Items.Add(compType);

            ComputerType.SelectedItem = TheComputer.ComputerType;

            CompSpeed.Value = (decimal)TheComputer.ComputationFactor;
        }

        private void ComputerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheComputer.ComputerType == (ComputerSystem.ComputerTypes)ComputerType.SelectedItem)
                return;

            TheComputer.ComputerType = (ComputerSystem.ComputerTypes)ComputerType.SelectedItem;
            CallInfoChanged(TheComputer);
        }

        private void CompSpeed_ValueChanged(object sender, EventArgs e)
        {
            if (TheComputer.ComputationFactor == (double)CompSpeed.Value)
                return;

            TheComputer.ComputationFactor = (double)CompSpeed.Value;
            CallInfoChanged(TheComputer);
        }
    }
}
