using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using SimCore.Entities;
using SimCore.Data;
using SimCore.Data.Systems;

namespace EntityBuilder.Inspectors
{
    public partial class BaseSystemInspector : BaseInspector
    {
        protected BaseSystem TheBaseSysem = null;
        public BaseSystemInspector()
        {
            InitializeComponent();
        }

        public override void Set(object item, Entity ent)
        {
            TheEntity = ent;
            TheBaseSysem = item as BaseSystem;
        }

        public override string GetItemName() { return GetSystemName(TheBaseSysem); }

        public static string GetSystemName(BaseSystem system)
        {
            return system.Name;
        }

        private void BaseSystemInspector_Load(object sender, EventArgs e)
        {
            SystemName.Text = TheBaseSysem.Name;

            HostLocation.Items.Clear();
            foreach (Entity.InternalLocation loc in TheEntity.Locations)
                HostLocation.Items.Add(loc);

            HostLocation.SelectedIndex = TheBaseSysem.LocationID;

            SystemLocation.Set(TheBaseSysem.SystemLocation);
            SystemLocation.ValueChanged += new EventHandler(SystemLocation_ValueChanged);

            foreach (ComputerSystem computer in TheEntity.Computers)
                ControlComputer.Items.Add(computer);

            ControlComputer.SelectedItem = TheEntity.GetSystemByID(TheBaseSysem.ControlComputer);
        }

        void SystemLocation_ValueChanged(object sender, EventArgs e)
        {
            TheBaseSysem.SystemLocation = SystemLocation.Vector;
            CallInfoChanged(this);
        }

        private void SystemName_TextChanged(object sender, EventArgs e)
        {
            TheBaseSysem.Name = SystemName.Text;
            CallNameChanged(this);
        }

        private void SystemLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            TheBaseSysem.LocationID = HostLocation.SelectedIndex;
            CallInfoChanged(this);
        }

        private void Draw_ValueChanged(object sender, EventArgs e)
        {
            if (TheBaseSysem.MaxPowerDraw == (double)Draw.Value)
                return;

            TheBaseSysem.MaxPowerDraw = (double)Draw.Value;
            CallInfoChanged(this);
        }

        private void MaxBuffer_ValueChanged(object sender, EventArgs e)
        {
            if (TheBaseSysem.MaxPowerBuffer == (double)MaxBuffer.Value)
                return;

            TheBaseSysem.MaxPowerBuffer = (double)MaxBuffer.Value;
            CallInfoChanged(this);
        }

        private void BaseEffectivness_ValueChanged(object sender, EventArgs e)
        {
            if (TheBaseSysem.BaseEfectivness == (double)BaseEffectivness.Value)
                return;

            TheBaseSysem.BaseEfectivness = (double)BaseEffectivness.Value;
            CallInfoChanged(this);
        }

        private void ControlComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputerSystem selectedComp = ControlComputer.SelectedItem as ComputerSystem;
            if (selectedComp == null)
                return;

            if (TheBaseSysem.ControlComputer == selectedComp.SystemID)
                return;

            TheBaseSysem.ControlComputer = selectedComp.SystemID;
            CallInfoChanged(this);
        }
    }
}
