using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using OpenTK;

namespace EntityBuilder.Controls
{
    public partial class Vector3Editor : UserControl
    {
        public Vector3d Vector = Vector3d.Zero;

        public event EventHandler ValueChanged;

        public bool UseDecimalIncrement = false;
        public bool UseLocks = false;

        public string UnlockCharacter = "Ð";
        public string LockCharacter = "Ï";

        [Browsable(true)]
        [Category("Appearance")]
        public string LabelName { get { return ValueName.Text; } set { if (ValueName != null) ValueName.Text = value; } }

        public Vector3Editor()
        {
            InitializeComponent();

            Set(Vector);
        }

        public void Set(Vector3d vec)
        {
            Vector = vec;

            XValue.Value = (decimal)Vector.X;
            YValue.Value = (decimal)Vector.Y;
            ZValue.Value = (decimal)Vector.Z;

            if (UseDecimalIncrement)
            {
                XValue.Increment = (decimal)0.001;
                YValue.Increment = (decimal)0.001;
                ZValue.Increment = (decimal)0.001;
            }
            else
            {
                XValue.Increment = (decimal)1;
                YValue.Increment = (decimal)1;
                ZValue.Increment = (decimal)1;
            }

            XYLock.Enabled = UseLocks;
            if (!UseLocks)
                YValue.Enabled = true;
        }

        private void XValue_ValueChanged(object sender, EventArgs e)
        {
            if ((double)XValue.Value == Vector.X)
                return;

            Vector.X = (double)XValue.Value;

            if (XYLock.Checked)
                YValue.Value = XValue.Value;

            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        private void YValue_ValueChanged(object sender, EventArgs e)
        {
            if ((double)YValue.Value == Vector.Y)
                return;

            Vector.Y = (double)YValue.Value;

            if (!XYLock.Checked && ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        private void ZValue_ValueChanged(object sender, EventArgs e)
        {
            if ((double)ZValue.Value == Vector.Z)
                return;

            Vector.Z = (double)ZValue.Value;

            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        private void Vector3Editor_Load(object sender, EventArgs e)
        {
            Set(Vector);
        }

        private void XYLock_CheckedChanged(object sender, EventArgs e)
        {
            XYLock.Text = XYLock.Checked ? LockCharacter : UnlockCharacter;

            if (XYLock.Checked)
            {
                YValue.Value = XValue.Value;
                YValue.Enabled = false;
            }
            else
                YValue.Enabled = true;
        }
    }
}
