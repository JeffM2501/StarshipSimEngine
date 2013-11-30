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
    public partial class ConnectionInspector : BaseInspector
    {
        public Entity.InternalLocation.ConnectionInfo TheConnection = null;

        public ConnectionInspector()
        {
            InitializeComponent();
        }

        public override void Set(object item, Entity ent)
        {
            base.Set(item, ent);
            TheConnection = item as Entity.InternalLocation.ConnectionInfo;
        }
        
        public static string GetConnectioName(Entity.InternalLocation.ConnectionInfo connection, Entity entity)
        {
            return "To " + (connection.TargetIndex >= 0 ? entity.Locations[connection.TargetIndex].Name : "Unknown");
        }

        public override string GetItemName()
        {
            return GetConnectioName(TheConnection,TheEntity);
        }

        private void ConnectionInspector_Load(object sender, EventArgs e)
        {
            ConnectionTarget.Items.Clear();
            foreach (Entity.InternalLocation loc in TheEntity.Locations)
                ConnectionTarget.Items.Add(loc);

            ConnectionTarget.SelectedIndex = TheConnection.TargetIndex;
            ConnectionLocation.Set(TheConnection.ConnectionPoint);
            ConnectionLocation.ValueChanged += new EventHandler(ConnectionLocation_ValueChanged);
        }

        void ConnectionLocation_ValueChanged(object sender, EventArgs e)
        {
            TheConnection.ConnectionPoint = ConnectionLocation.Vector;
            CallInfoChanged(this);
        }

        private void ConnectionTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheConnection.TargetIndex == ConnectionTarget.SelectedIndex)
                return;

            TheConnection.TargetIndex = ConnectionTarget.SelectedIndex;
            CallNameChanged(this);
        }
    }
}
