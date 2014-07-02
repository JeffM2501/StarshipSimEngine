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

        public event EventHandler<PowerTempControl.ValueEventArgs> SetPower;
        public event EventHandler<PowerTempControl.ValueEventArgs> SetCoolant;
        public event EventHandler<PowerTempControl.ValueEventArgs> Activate;

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

            PowerTemp.Setup(system.MaxPower, system.MaxCoolantFlow, system.NominalTemp * 3, system.Essential);

            PowerTemp.SetPower += PowerTemp_SetPower;
            PowerTemp.SetCoolant += PowerTemp_SetCoolant;
 
            DoActivate.Visible = system.ActivationHeat > 0;
 
            if (system.ActivationHeat > 0)
                SystemName.Width -= DoActivate.Width + 4;

            DoUpdate();
        }

        
        void PowerTemp_SetPower(object sender, PowerTempControl.ValueEventArgs e)
        {
             if (InspectedSystem.Essential && e.Value < InspectedSystem.MinimumPower)
             {
                 SetDesiredPower(InspectedSystem.MinimumPower);
                 return;
             }

             if (e.Value == InspectedSystem.DesiredPower)
                 return;

             if (SetPower != null)
                 SetPower(this, e);

             DoUpdate();
        }


        void PowerTemp_SetCoolant(object sender, PowerTempControl.ValueEventArgs e)
        {
            if (e.Value == InspectedSystem.DesiredCoolantFlow)
                return;

            if (SetCoolant != null)
                SetCoolant(this, e);

            DoUpdate();
        }

        public void DoUpdate()
        {
            PowerTemp.SetDisplayPower(InspectedSystem.CurrentPower);
            PowerTemp.SetDisplayCoolant(InspectedSystem.CurrentCoolantFlow);
            PowerTemp.SetDisplayTemp(InspectedSystem.CurrentTemp);
            PowerTemp.SetDisplayTempDelta(InspectedSystem.TempDelta);
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            if (Activate != null)
                Activate(this, new PowerTempControl.ValueEventArgs(1));

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
              if (value > InspectedSystem.MaxPower)
                  value = InspectedSystem.MaxPower;

              PowerTemp.SetInputPower(value);
         }
 
         public void SetDesiredCoolant(float value)
         {
             if (value > InspectedSystem.MaxCoolantFlow)
                 value = InspectedSystem.MaxCoolantFlow;

             PowerTemp.SetInputCoolant(value);
         }
    }
}
