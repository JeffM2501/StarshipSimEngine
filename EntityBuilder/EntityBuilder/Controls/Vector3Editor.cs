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

        public string LabelText { get { return ValueName.Text; } set { ValueName.Text = value; } }

        public Vector3Editor()
        {
            InitializeComponent();

            XValue.Value = (decimal)Vector.X;
            YValue.Value = (decimal)Vector.Y;
            ZValue.Value = (decimal)Vector.Z;
        }

        private void XValue_ValueChanged(object sender, EventArgs e)
        {
            if ((double)XValue.Value == Vector.X)
                return;

            Vector.X = (double)XValue.Value;
        }

        private void YValue_ValueChanged(object sender, EventArgs e)
        {
            if ((double)YValue.Value == Vector.Y)
                return;

            Vector.Y = (double)YValue.Value;
        }

        private void ZValue_ValueChanged(object sender, EventArgs e)
        {
            if ((double)ZValue.Value == Vector.Z)
                return;

            Vector.Z = (double)ZValue.Value;
        }

        private void Vector3Editor_Load(object sender, EventArgs e)
        {
            ValueName.Text = Name;
        }
    }
}
