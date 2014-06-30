using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ShipSystems;

namespace CoolantTest
{
    public partial class ResevoirInspector : UserControl
    {
        public CoolantSystem.Reservoir InspectedReservoir = null;
        public CoolantSystem InspectedCoolant = null;

        public ResevoirInspector()
        {
            InitializeComponent();
        }

        public ResevoirInspector(CoolantSystem coolant, int index)
        {
            InitializeComponent();
            InspectedCoolant = coolant;
            Setup(coolant.Reservoirs[index]);
        }

        public void Setup(CoolantSystem.Reservoir reservoir)
        {
            InspectedReservoir = reservoir;

            ResevourID.Text = reservoir.ID.ToString();

            CoolantBar.Maximum = (int)reservoir.MaxCoolant;
            CoolantBar.Minimum = 0;

            TempBar.Maximum = (int)InspectedCoolant.NominalTemp * 3;
            TempBar.Minimum = 0;

            Connected.Checked = reservoir.Connected;

            DoUpdate();
        }

        public void DoUpdate()
        {
            CoolantBar.Value = (int)InspectedReservoir.TotalCoolant;
            CoolantValue.Text = InspectedReservoir.TotalCoolant.ToString();

            TempBar.Value = (int)InspectedReservoir.Temurature;
            TempValue.Text = InspectedReservoir.Temurature.ToString();
        }

        private void Connected_CheckedChanged(object sender, EventArgs e)
        {
             if (InspectedReservoir.TotalCoolant <= 0)
                 Connected.Checked = false;

            if (Connected.Checked == InspectedReservoir.Connected)
                return;

            if (Connected.Checked)
                InspectedCoolant.ConnectReserve(InspectedReservoir);
            else
                InspectedCoolant.DisconnectReserve(InspectedReservoir);
        }

        private void Flush_Click(object sender, EventArgs e)
        {
            InspectedCoolant.FlushReserve(InspectedReservoir);
            if (InspectedReservoir.TotalCoolant <= 0)
            {
                Connected.Checked = false;
                Connected_CheckedChanged(this, EventArgs.Empty);
            }
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            InspectedCoolant.RefillReserve(InspectedReservoir, InspectedReservoir.MaxCoolant);

           
        }

        private void ToSystem_Click(object sender, EventArgs e)
        {
            InspectedCoolant.TransferFromReserveToSystem(InspectedReservoir, InspectedReservoir.TotalCoolant);

            if (InspectedReservoir.TotalCoolant <= 0)
            {
                Connected.Checked = false;
                Connected_CheckedChanged(this, EventArgs.Empty);
            }
        }
    }
}
