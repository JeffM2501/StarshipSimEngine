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
    public partial class LocationInspector : UserControl
    {
        public Entity.InternalLocation TheLocation = null;

        public event EventHandler LocationNameChanged;

        public event EventHandler LocationGeometryChanged;

        public LocationInspector()
        {
            InitializeComponent();
        }

        public LocationInspector(Entity.InternalLocation location)
        {
            InitializeComponent();
            TheLocation = location;
        }

        private void LocationInspector_Load(object sender, EventArgs e)
        {
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
            }
        }

        private void LocationName_TextChanged(object sender, EventArgs e)
        {
            if (Location != null && LocationName.Text == TheLocation.Name)
                return;

            TheLocation.Name = LocationName.Text;
            if (LocationNameChanged != null)
                LocationNameChanged(Location, EventArgs.Empty);
        }

        private void LocationGeoChanged(object sender, EventArgs e)
        {
            if (LocationGeometryChanged != null)
                LocationGeometryChanged(Location, EventArgs.Empty);
        }
    }
}
