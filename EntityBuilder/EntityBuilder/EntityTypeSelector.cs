using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Entities;

namespace EntityBuilder
{
    public partial class EntityTypeSelector : Form
    {
        public string EntityName = string.Empty;
        public bool IsShip = false;
        public CelestialObject.Categories CelestialCategory = CelestialObject.Categories.Unknown;

        public EntityTypeSelector()
        {
            InitializeComponent();
        }

        private void EntityTypeSelector_Load(object sender, EventArgs e)
        {
            foreach(CelestialObject.Categories c in Enum.GetValues(typeof(CelestialObject.Categories)))
            {
                EntityType.Items.Add(c);
            }

            if (IsShip)
                ShipRB.Checked = true;
            else
                CelestialRB.Checked = true;

            EntityType.SelectedItem = CelestialCategory;
            EntityNameTE.Text = EntityName;
        }

        private void ShipRB_CheckedChanged(object sender, EventArgs e)
        {
            EntityTypeGroup.Enabled = false;
        }

        private void CelestialRB_CheckedChanged(object sender, EventArgs e)
        {
            EntityTypeGroup.Enabled = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            EntityName = EntityNameTE.Text;
            IsShip = ShipRB.Checked;
            CelestialCategory = (CelestialObject.Categories)EntityType.SelectedItem;
        }
    }
}
