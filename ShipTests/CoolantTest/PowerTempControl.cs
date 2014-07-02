using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoolantTest
{
    public partial class PowerTempControl : UserControl
    {
        public class ValueEventArgs : EventArgs
        {
            public float Value;

            public ValueEventArgs(float value)
            {
                Value = value;
            }
        }

        public event EventHandler<ValueEventArgs> SetPower;
        public event EventHandler<ValueEventArgs> SetCoolant;

        public PowerTempControl()
        {
            InitializeComponent();
        }

        public void Setup(float maxPower, float maxCool, float maxTemp, bool essential)
        {            
            PowerBar.Maximum = (int)maxPower;
            PowerBar.Minimum = 0;

            PowerTrack.Maximum = PowerBar.Maximum;
            PowerTrack.Minimum = PowerBar.Minimum;

            CoolantBar.Maximum = (int)maxCool;
            CoolantBar.Minimum = 0;

            CoolantTrack.Maximum = CoolantBar.Maximum;
            CoolantTrack.Minimum = CoolantBar.Minimum;

            TempBar.Maximum = (int)maxTemp;
            TempBar.Minimum = 0;

            EssentialLabel.Visible = essential;
        }

        public void SetDisplayTempDelta(float delta)
        {
            TempDelta.Text = string.Empty;
            if (delta > 0.01f)
            {
                TempDelta.Text = "5";
                TempDelta.ForeColor = Color.Red;
            }
            if (delta < -0.01f)
            {
                TempDelta.Text = "6";
                TempDelta.ForeColor = Color.Blue;
            }
        }

        public void SetDisplayPower(float value)
        {
            PowerBar.Value = (int)value;
            PowerValue.Text = value.ToString();
        }

        public void SetDisplayTemp(float value)
        {
            if (value > TempBar.Maximum)
                value = TempBar.Maximum;

            TempBar.Value = (int)value;
            TempValue.Text = value.ToString();
        }

        public void SetDisplayCoolant (float value)
        {
            CoolantBar.Value = (int)value;
            CoolantValue.Text = value.ToString();
        }

        public void SetInputPower(float power)
        {
            PowerTrack.Value = (int)power;
            PowerTrack_Scroll(this, EventArgs.Empty);
        }

        public void SetInputCoolant(float power)
        {
            CoolantTrack.Value = (int)power;
            CoolantTrack_Scroll(this, EventArgs.Empty);
        }

        private void PowerTrack_Scroll(object sender, EventArgs e)
        {
            if (SetPower != null)
                SetPower(this, new ValueEventArgs(PowerTrack.Value));
        }

        private void CoolantTrack_Scroll(object sender, EventArgs e)
        {
            if (SetCoolant != null)
                SetCoolant(this, new ValueEventArgs(CoolantTrack.Value));
        }
    }
}
