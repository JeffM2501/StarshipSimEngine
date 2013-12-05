using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EntityBuilder.Inspectors;
using SimCore.Entities;


namespace EntityBuilder.Inspectors.Entities
{
    public partial class ShipEntityInspector : BaseEntityInspector
    {
        protected StarShip Ship = null;

        public ShipEntityInspector() : base()
        {
            InitializeComponent();

            foreach (StarShip.StarShipSizeClasses size in Enum.GetValues(typeof(StarShip.StarShipSizeClasses)))
                SizeClassList.Items.Add(size);
        }

        public override void Set(object item, Entity ent)
        {
            base.Set(item, ent);
            Ship = ent as StarShip;

            if (Ship == null)
                return;

            SizeClassList.SelectedItem = Ship.SizeClass;


            if (Ship.OwnerFaction == UInt64.MaxValue)
                FactionID.Value = -1;
            else
                FactionID.Value = (decimal)Ship.OwnerFaction;
        }

        private void SizeClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ship.SizeClass == (StarShip.StarShipSizeClasses)SizeClassList.SelectedItem)
                return;

            Ship.SizeClass = (StarShip.StarShipSizeClasses)SizeClassList.SelectedItem;

            CallInfoChanged(TheEntity);
        }

        private void FactionID_ValueChanged(object sender, EventArgs e)
        {
            if (FactionID.Value == -1 && Ship.OwnerFaction == UInt64.MaxValue)
                return;

            if (Ship.OwnerFaction == (UInt64)FactionID.Value)
                return;

            if (FactionID.Value == -1)
                Ship.OwnerFaction = UInt64.MaxValue;
            else
                Ship.OwnerFaction = (UInt64)FactionID.Value;
            CallInfoChanged(TheEntity);
        }
    }
}
