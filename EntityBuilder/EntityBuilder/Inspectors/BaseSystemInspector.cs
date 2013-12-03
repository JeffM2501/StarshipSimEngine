using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using SimCore.Entities;
using SimCore.Data;
using SimCore.Data.Systems;

namespace EntityBuilder.Inspectors
{
    public partial class BaseSystemInspector : BaseInspector
    {
        protected BaseSystem TheBaseSysem = null;
        public BaseSystemInspector()
        {
            InitializeComponent();
        }

        public override void Set(object item, Entity ent)
        {
            TheEntity = ent;
            TheBaseSysem = item as BaseSystem;
        }

        public override string GetItemName() { return TheBaseSysem.Name; }

        private void BaseSystemInspector_Load(object sender, EventArgs e)
        {
            SystemName.Text = TheBaseSysem.Name;

            HostLocation.Items.Clear();
            foreach (Entity.InternalLocation loc in TheEntity.Locations)
                HostLocation.Items.Add(loc);

            HostLocation.SelectedIndex = TheBaseSysem.LocationID;

            SystemLocation.Set(TheBaseSysem.SystemLocation);
            SystemLocation.ValueChanged += new EventHandler(SystemLocation_ValueChanged);
        }

        void SystemLocation_ValueChanged(object sender, EventArgs e)
        {
            TheBaseSysem.SystemLocation = SystemLocation.Vector;
            CallInfoChanged(this);
        }

        private void SystemName_TextChanged(object sender, EventArgs e)
        {
            TheBaseSysem.Name = SystemName.Text;
            CallNameChanged(this);
        }

        private void SystemLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            TheBaseSysem.LocationID = HostLocation.SelectedIndex;
            CallInfoChanged(this);
        }
    }
}
