using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

using OpenTK;

using SimCore.Entities;
using SimCore.Data;
using SimCore.Data.Systems;

using EntityBuilder.Inspectors;

namespace EntityBuilder
{
    partial class MainForm
    {
        protected TreeNode EntityRootNode = null;

        protected void InitSidebar()
        {
            InitInspectors();
        }

        protected TreeNode GetSelectedLocationTreeNode()
        {
            if (EntityRootNode == null)
                return null;

            Entity.InternalLocation loc = GetSelectedLocation();
            foreach (TreeNode node in EntityRootNode.Nodes)
            {
                if (node.Tag == loc)
                    return node;
            }

            return null;
        }
        protected Entity.InternalLocation GetSelectedLocation()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            Entity.InternalLocation loc = ComponentsList.SelectedNode.Tag as Entity.InternalLocation;

            if (loc != null)
                return loc;

            BaseSystem sys = ComponentsList.SelectedNode.Tag as BaseSystem;
            if (sys != null && (sys.LocationID >=0 && sys.LocationID < TheEntity.Locations.Count))
                return TheEntity.Locations[sys.LocationID];

            Entity.InternalLocation.ConnectionInfo info = ComponentsList.SelectedNode.Tag as Entity.InternalLocation.ConnectionInfo;
            if (info != null && ComponentsList.SelectedNode.Parent != null)
                return ComponentsList.SelectedNode.Parent.Tag as Entity.InternalLocation;

            return null;
        }

        protected BaseSystem GetSelectedSystem()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            return ComponentsList.SelectedNode.Tag as BaseSystem;
        }

        protected Entity.InternalLocation.ConnectionInfo GetSelectedConnection()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            return ComponentsList.SelectedNode.Tag as Entity.InternalLocation.ConnectionInfo;
        }

        public void DeselectComponents()
        {
            ComponentsList.SelectedNode = null;
            Draw();
        }

        protected TreeNode AddSystemNode(BaseSystem system, TreeNode locNode)
        {
            if (locNode == null)
                return null;

            TreeNode node = new TreeNode(BaseSystemInspector.GetSystemName(system));
            node.Tag = system;
            node.ImageIndex = 1;
            locNode.Nodes.Add(node);

            return node;
        }

        public void AddSystemsToNode(IEnumerable<BaseSystem> systemList, TreeNode root, int locID)
        {
            foreach (BaseSystem system in systemList)
            {
                if (system.LocationID != locID)
                    continue;

                AddSystemNode(system, root);
            }
        }

        protected TreeNode AddConnectionNode(Entity.InternalLocation.ConnectionInfo connection, TreeNode locNode)
        {
            if (locNode == null)
                return null;

            TreeNode node = new TreeNode(ConnectionInspector.GetConnectioName(connection, TheEntity));
            node.Tag = connection;
            node.ImageIndex = 2;
            locNode.Nodes.Add(node);

            return node;
        }

        protected TreeNode AddLocatioNode(Entity.InternalLocation loc)
        {
            TreeNode node = new TreeNode(loc.ToString());
            node.Tag = loc;
            node.ImageIndex = 11;
            EntityRootNode.Nodes.Add(node);

            return node;
        }

        protected void AddConnectionNodes(Entity.InternalLocation loc, TreeNode locNode)
        {
            foreach (Entity.InternalLocation.ConnectionInfo connection in loc.Connections)
                AddConnectionNode(connection, locNode);
        }

        public void BuildLocationList()
        {
            ComponentsList.Nodes.Clear();

            EntityRootNode = new TreeNode(TheEntity.Name);
            EntityRootNode.Tag = TheEntity;
            EntityRootNode.ImageIndex = 13;

            ComponentsList.Nodes.Add(EntityRootNode);

            BaseSystem[] systemList = TheEntity.GetSystemList();

            foreach (Entity.InternalLocation loc in TheEntity.Locations)
            {
                TreeNode node = AddLocatioNode(loc);

                AddConnectionNodes(loc, node);
                AddSystemsToNode(systemList, node, loc.Index);
            }
            ComponentsList.ExpandAll();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation location = new Entity.InternalLocation();
            location.Name = "New Location";
            location.Index = TheEntity.Locations.Count;
            TheEntity.Locations.Add(location);

            TreeNode node = AddLocatioNode(location);
            ComponentsList.SelectedNode = node;

            Dirty();
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation currentLoc = GetSelectedLocation();
            if (currentLoc == null)
                return;

            Entity.InternalLocation location = new Entity.InternalLocation();
            location.Name = "New Location";
            location.Index = TheEntity.Locations.Count;
            location.Orientation = new Quaterniond(currentLoc.Orientation.Xyz, currentLoc.Orientation.W);
            location.Origin = new Vector3d(currentLoc.Origin);
            location.Size = new Vector3d(currentLoc.Size);
            location.Shape = currentLoc.Shape;
            TheEntity.Locations.Add(location);

            TreeNode node = new TreeNode(location.ToString());
            node.Tag = location;
            EntityRootNode.Nodes.Add(node);
            ComponentsList.SelectedNode = node;

            Dirty();
        }

        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation currentLoc = GetSelectedLocation();
            if (currentLoc == null)
                return;

            Entity.InternalLocation.ConnectionInfo con = new Entity.InternalLocation.ConnectionInfo();
            con.ConnectionPoint = new Vector3d(currentLoc.Origin); // start it at the sections origin
            currentLoc.Connections.Add(con);

            ComponentsList.SelectedNode = AddConnectionNode(con, GetSelectedLocationTreeNode());

            Dirty();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation currentLoc = GetSelectedLocation();
            if (currentLoc == null)
                return;

            SystemTypeSelector selector = new SystemTypeSelector();
            if (selector.ShowDialog(this) == DialogResult.OK)
            {
                BaseSystem system = Activator.CreateInstance(selector.SystemType) as BaseSystem;

                system.SystemName = "New " + system.GetType().Name;
                system.LocationID = currentLoc.Index;
                TheEntity.AddSystem(system);

                ComponentsList.SelectedNode = AddSystemNode(system, GetSelectedLocationTreeNode());

                Dirty();
            }
        }

        private void ComponentContextMenu_Opening(object sender, CancelEventArgs e)
        {
            ComponentContextMenu.Enabled = TheEntity != null;
            foreach (ToolStripItem item in locationToolStripMenuItem.DropDownItems)
                item.Enabled = locationToolStripMenuItem.Enabled;
        }

        private void locationToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            locationToolStripMenuItem.Enabled = TheEntity != null;
            foreach (ToolStripItem item in locationToolStripMenuItem.DropDownItems)
                item.Enabled = locationToolStripMenuItem.Enabled;
        }

        private void systemToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            systemToolStripMenuItem.Enabled = TheEntity != null;
            foreach (ToolStripItem item in systemToolStripMenuItem.DropDownItems)
                item.Enabled = systemToolStripMenuItem.Enabled;
        }

        private void ComponentsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ComponentsList.SelectedNode != null)
                LoadInspector(ComponentsList.SelectedNode.Tag);
            else
                InspectorArea.Controls.Clear();
            Draw();
        }

    }
}
