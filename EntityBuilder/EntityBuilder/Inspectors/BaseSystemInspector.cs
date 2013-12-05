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
        protected BaseSystem TheBaseSystem = null;
        public BaseSystemInspector() : base()
        {
            InitializeComponent();
        }

        public override void Set(object item, Entity ent)
        {
            TheEntity = ent;
            TheBaseSystem = item as BaseSystem;

            if (TheBaseSystem == null)
                return;

            SystemName.Text = TheBaseSystem.SystemName;

            SystemLocation.Set(TheBaseSystem.SystemLocation);
            SystemLocation.ValueChanged += new EventHandler(SystemLocation_ValueChanged);

            foreach (ComputerSystem computer in TheEntity.Computers)
                ControlComputer.Items.Add(computer);

            ControlComputer.SelectedItem = TheEntity.GetSystemByID(TheBaseSystem.ControlComputer);
        }

        public override string GetItemName() { return GetSystemName(TheBaseSystem); }

        public static string GetSystemName(BaseSystem system)
        {
            return system.SystemName;
        }

        private void BaseSystemInspector_Load(object sender, EventArgs e)
        {
        }

        void SystemLocation_ValueChanged(object sender, EventArgs e)
        {
            TheBaseSystem.SystemLocation = SystemLocation.Vector;
            CallInfoChanged(this);
        }

        private void SystemName_TextChanged(object sender, EventArgs e)
        {
            TheBaseSystem.SystemName = SystemName.Text;
            CallNameChanged(this);
        }

        private void Draw_ValueChanged(object sender, EventArgs e)
        {
            if (TheBaseSystem.MaxPowerDraw == (double)Draw.Value)
                return;

            TheBaseSystem.MaxPowerDraw = (double)Draw.Value;
            CallInfoChanged(this);
        }

        private void MaxBuffer_ValueChanged(object sender, EventArgs e)
        {
            if (TheBaseSystem.MaxPowerBuffer == (double)MaxBuffer.Value)
                return;

            TheBaseSystem.MaxPowerBuffer = (double)MaxBuffer.Value;
            CallInfoChanged(this);
        }

        private void BaseEffectivness_ValueChanged(object sender, EventArgs e)
        {
            if (TheBaseSystem.BaseEfectivness == (double)BaseEffectivness.Value)
                return;

            TheBaseSystem.BaseEfectivness = (double)BaseEffectivness.Value;
            CallInfoChanged(this);
        }

        private void ControlComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComputerSystem selectedComp = ControlComputer.SelectedItem as ComputerSystem;
            if (selectedComp == null)
                return;

            if (TheBaseSystem.ControlComputer == selectedComp.SystemID)
                return;

            TheBaseSystem.ControlComputer = selectedComp.SystemID;
            CallInfoChanged(this);
        }
    }
}
