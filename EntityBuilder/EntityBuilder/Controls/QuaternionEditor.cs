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
    public partial class QuaternionEditor : UserControl
    {
        public event EventHandler ValueChanged; 

        public Quaterniond QuaternionValue = new Quaterniond(0,0,1,0);
        public string LabelText { get { return VectorEdit.LabelText; } set { VectorEdit.LabelText = value; } }

        public QuaternionEditor()
        {
            InitializeComponent();
            VectorEdit.ValueChanged += new EventHandler(VectorEdit_VectorChanged);
        }

        private void VectorEdit_Load(object sender, EventArgs e)
        {
            Set(QuaternionValue);
        }

        public void Set(Quaterniond quat)
        {
            QuaternionValue = quat;
            VectorEdit.Set(QuaternionValue.Xyz);
            RotationValue.Value = (decimal)QuaternionValue.W;
            CheckPreset();
        }

        void VectorEdit_VectorChanged(object sender, EventArgs e)
        {
            if (QuaternionValue.Xyz.Equals(VectorEdit.Vector))
                return;

            QuaternionValue.Xyz = VectorEdit.Vector;
            CheckPreset();

            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        private void RotationValue_ValueChanged(object sender, EventArgs e)
        {
            if (QuaternionValue.W == (double)RotationValue.Value)
                return;

            QuaternionValue.W = (double)RotationValue.Value;
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        private void CheckPreset()
        {
            int selection = 0;

            if (QuaternionValue.Xyz.Equals(Vector3d.UnitX))
                selection = 1;
            else if (QuaternionValue.Xyz.Equals(Vector3d.UnitY))
                selection = 2;
            else if (QuaternionValue.Xyz.Equals(Vector3d.UnitZ))
                selection = 3;
            else if (QuaternionValue.Xyz.Equals(Vector3d.UnitX * -1))
                selection = 4;
            else if (QuaternionValue.Xyz.Equals(Vector3d.UnitY * -1))
                selection = 5;
            else if (QuaternionValue.Xyz.Equals(Vector3d.UnitZ * -1))
                selection = 6;

            if (PresetList.SelectedIndex != selection)
                PresetList.SelectedIndex = selection;
        }

        private void PresetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PresetList.SelectedIndex == 0)
                return;

            switch (PresetList.SelectedIndex)
            {
                case 0:
                    return;

                case 1:
                    VectorEdit.Set(Vector3d.UnitX);
                    break;
                case 2:
                    VectorEdit.Set(Vector3d.UnitY);
                    break;
                case 3:
                    VectorEdit.Set(Vector3d.UnitZ);
                    break;
                case 4:
                    VectorEdit.Set(Vector3d.UnitX * -1);
                    break;
                case 5:
                    VectorEdit.Set(Vector3d.UnitY * -1);
                    break;
                case 6:
                    VectorEdit.Set(Vector3d.UnitZ * -1);
                    break;
            }

            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }


    }
}
