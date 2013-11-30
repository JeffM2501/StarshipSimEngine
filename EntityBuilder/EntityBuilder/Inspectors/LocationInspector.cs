using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Entities;

namespace EntityBuilder.Inspectors
{
    public partial class LocationInspector : BaseInspector
    {
        public Entity.InternalLocation TheLocation = null;

        public LocationInspector()
        {
            InitializeComponent();
            GeoSize.UseLocks = true;
        }

        public override void Set(object item)
        {
            Entity.InternalLocation location = item as Entity.InternalLocation;
            TheLocation = location;
        }

        private void LocationInspector_Load(object sender, EventArgs e)
        {
            GeoSize.UseLocks = true;
            ShapeList.Items.Clear();
            foreach (Entity.InternalLocation.LocaionShapes shape in Enum.GetValues(typeof(Entity.InternalLocation.LocaionShapes)))
                ShapeList.Items.Add(shape);

            if (Location != null)
            {
                LocationName.Text = TheLocation.Name;
                ShapeList.SelectedItem = TheLocation.Shape;

                Origin.Set(TheLocation.Origin);
                Orientation.Set(TheLocation.Orientation);
                GeoSize.Set(TheLocation.Size);

                Origin.ValueChanged += new EventHandler(Origin_ValueChanged);
                Orientation.ValueChanged += new EventHandler(Orientation_ValueChanged);
                GeoSize.ValueChanged += new EventHandler(GeoSize_ValueChanged);
            }
        }

        void GeoSize_ValueChanged(object sender, EventArgs e)
        {
            TheLocation.Size = GeoSize.Vector;
            CallInfoChanged(TheLocation);
        }

        void Orientation_ValueChanged(object sender, EventArgs e)
        {
            TheLocation.Orientation = Orientation.QuaternionValue;
            CallInfoChanged(TheLocation);
        }

        void Origin_ValueChanged(object sender, EventArgs e)
        {
            TheLocation.Origin = Origin.Vector;
            CallInfoChanged(TheLocation);
        }

        private void LocationName_TextChanged(object sender, EventArgs e)
        {
            if (TheLocation != null && LocationName.Text == TheLocation.Name)
                return;

            TheLocation.Name = LocationName.Text;
            ItemName = TheLocation.Name;
            CallNameChanged(TheLocation);
        }

        private void ShapeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheLocation.Shape == (Entity.InternalLocation.LocaionShapes)ShapeList.SelectedItem)
                return;

            TheLocation.Shape = (Entity.InternalLocation.LocaionShapes)ShapeList.SelectedItem;

            CallInfoChanged(TheLocation);
        }
    }
}
