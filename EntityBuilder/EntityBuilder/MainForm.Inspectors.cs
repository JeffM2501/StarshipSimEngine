using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SimCore.Entities;

using EntityBuilder.Inspectors;

namespace EntityBuilder
{
    partial class MainForm
    {
        public void LoadLocationInspector(Entity.InternalLocation location)
        {
            InspectorArea.Controls.Clear();
            LocationInspector inspector = new LocationInspector(location);
            InspectorArea.Controls.Add(inspector);
            inspector.NameChanged += new EventHandler(inspector_LocationNameChanged);
            inspector.InfoChanged += new EventHandler(inspector_LocationGeometryChanged);
            inspector.Show();
        }

        void inspector_LocationGeometryChanged(object sender, EventArgs e)
        {
            Dirty();
        }

        void inspector_LocationNameChanged(object sender, EventArgs e)
        {
            Entity.InternalLocation location = sender as Entity.InternalLocation;
            if (location == null)
                return;

            foreach (TreeNode node in ComponentsList.Nodes)
            {
                if (node.Tag == location)
                    node.Text = location.Name;
            }
        }
    }
}
