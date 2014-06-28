using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShipSystems;

namespace CoolantTest
{
    public partial class ShipSystemInspector : UserControl
    {
        public ShipSystem InspectedSystem = null;

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
         //   SuspendLayout();
            InspectedSystem = system;

            SystemName.Text = InspectedSystem.SystemName;

            PowerBar.Maximum = (int)system.MaxPower;
            PowerBar.Minimum = 0;

            PowerTrack.Maximum = PowerBar.Maximum;
            PowerTrack.Minimum = PowerBar.Minimum;

            PowerTrack.Value = (int)system.CurrentPower;

            CoolantBar.Maximum = (int)system.MaxCoolantFlow;
            CoolantBar.Minimum = 0;

            CoolantTrack.Maximum = CoolantBar.Maximum;
            CoolantTrack.Minimum = CoolantBar.Minimum;
            CoolantTrack.Value = (int)system.CurrentCoolantFlow;

            TempBar.Maximum = (int)system.NominalTemp * 3;
            TempBar.Minimum = 0;

            DoActivate.Visible = system.ActivationHeat > 0;

            if (system.ActivationHeat > 0)
                SystemName.Width -= DoActivate.Width + 4;

            DoUpdate();

       //     ResumeLayout();
        }

        public void DoUpdate()
        {
            PowerBar.Value = (int)InspectedSystem.CurrentPower;
            PowerValue.Text = InspectedSystem.CurrentPower.ToString();

            CoolantBar.Value = (int)InspectedSystem.CurrentCoolantFlow;
            CoolantValue.Text = InspectedSystem.CurrentCoolantFlow.ToString();

            TempBar.Value = (int)InspectedSystem.CurrentTemp;
            TempValue.Text = InspectedSystem.CurrentTemp.ToString();
        }

        private void PowerTrack_Scroll(object sender, EventArgs e)
        {
            InspectedSystem.CurrentPower = PowerTrack.Value;
            DoUpdate();
        }

        private void CoolantTrack_Scroll(object sender, EventArgs e)
        {
            InspectedSystem.CurrentCoolantFlow = CoolantTrack.Value;
            DoUpdate();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            InspectedSystem.Activate();
            DoUpdate();
        }
    }
}
