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
    public partial class ShipSystemInspector : UserControl
    {
        public ShipSystem InspectedSystem = null;

        public class ShipSystemValueEventArgs : EventArgs
        {
            public float Value;

            public ShipSystemValueEventArgs (float value)
            {
                Value = value;
            }
        }

        public event EventHandler<ShipSystemValueEventArgs> SetPower;
        public event EventHandler<ShipSystemValueEventArgs> SetCoolant;
        public event EventHandler<ShipSystemValueEventArgs> Activate;

        public ShipSystemInspector()
        {
            InitializeComponent();
        }

        public ShipSystemInspector(ShipSystem system)
        {
            InitializeComponent();
            Setup(system);
        }

        public void Setup(ShipSystem system)
        {
            InspectedSystem = system;

            SystemName.Text = InspectedSystem.SystemName;

            PowerBar.Maximum = (int)system.MaxPower;
            PowerBar.Minimum = 0;

            PowerTrack.Maximum = PowerBar.Maximum;
            PowerTrack.Minimum = PowerBar.Minimum;

            PowerTrack.Value = (int)system.DesiredPower;

            CoolantBar.Maximum = (int)system.MaxCoolantFlow;
            CoolantBar.Minimum = 0;

            CoolantTrack.Maximum = CoolantBar.Maximum;
            CoolantTrack.Minimum = CoolantBar.Minimum;
            CoolantTrack.Value = (int)system.DesiredCoolantFlow;

            TempBar.Maximum = (int)system.NominalTemp * 3;
            TempBar.Minimum = 0;

            DoActivate.Visible = system.ActivationHeat > 0;

            if (system.ActivationHeat > 0)
                SystemName.Width -= DoActivate.Width + 4;

            EssentialLabel.Visible = InspectedSystem.Essential;

            DoUpdate();
        }

        public void DoUpdate()
        {
            PowerBar.Value = (int)InspectedSystem.CurrentPower;
            PowerValue.Text = InspectedSystem.CurrentPower.ToString();

            CoolantBar.Value = (int)InspectedSystem.CurrentCoolantFlow;
            CoolantValue.Text = InspectedSystem.CurrentCoolantFlow.ToString();

            if (InspectedSystem.CurrentTemp > TempBar.Maximum)
                TempBar.Value = TempBar.Maximum;
            else
                TempBar.Value = (int)InspectedSystem.CurrentTemp;
            TempValue.Text = InspectedSystem.CurrentTemp.ToString();
        }

        private void PowerTrack_Scroll(object sender, EventArgs e)
        {
            if (InspectedSystem.Essential && PowerTrack.Value < InspectedSystem.MinimumPower)
            { 
                SetDesiredPower(InspectedSystem.MinimumPower);
                return;
            }

            if (PowerTrack.Value == InspectedSystem.DesiredPower)
                return;

            if (SetPower != null)
                SetPower(this, new ShipSystemValueEventArgs(PowerTrack.Value));

            DoUpdate();
        }

        private void CoolantTrack_Scroll(object sender, EventArgs e)
        {
            if (CoolantTrack.Value == InspectedSystem.DesiredCoolantFlow)
                return;

            if (SetCoolant != null)
                SetCoolant(this, new ShipSystemValueEventArgs(CoolantTrack.Value));

            DoUpdate();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            if (Activate != null)
                Activate(this, new ShipSystemValueEventArgs(1));

            DoUpdate();
        }

        private void NominalPower_Click(object sender, EventArgs e)
        {
            SetDesiredPower(InspectedSystem.NominalPower);
        }

        private void MinPower_Click(object sender, EventArgs e)
        {
            SetDesiredPower(InspectedSystem.MinimumPower);
        }

        private void DoublePower_Click(object sender, EventArgs e)
        {
            SetDesiredPower(InspectedSystem.NominalPower * 2);
        }

        private void MaxPower_Click(object sender, EventArgs e)
        {
            SetDesiredPower(InspectedSystem.MaxPower);
        }

        public void SetDesiredPower(float value)
        {
            PowerTrack.Value = (int)value;
            PowerTrack_Scroll(this, EventArgs.Empty);
        }

        public void SetDesiredCoolant(float value)
        {
            CoolantTrack.Value = (int)value;
            CoolantTrack_Scroll(this, EventArgs.Empty);
        }
    }
}
