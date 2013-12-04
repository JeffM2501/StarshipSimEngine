using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Data.Systems;
using SimCore.Utilities;

namespace EntityBuilder
{
    public partial class SystemTypeSelector : Form
    {
        public Type SystemType = typeof(BaseSystem);

        public class TypeListItem
        {
            public Type T = null;
            public string Name = string.Empty;

            public TypeListItem(Type t)
            {
                T = t;
                Name = t.Name;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public SystemTypeSelector()
        {
            InitializeComponent();

            foreach (Type t in SimCore.Utilities.Utils.GetSystemTypes())
            {
                SystemTypeList.Items.Add(new TypeListItem(t));
            }

            SystemTypeList.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SystemType = (SystemTypeList.SelectedItem as TypeListItem).T;
        }

        private void SystemTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
