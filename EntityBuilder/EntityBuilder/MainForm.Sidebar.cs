﻿using System;
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
        protected void InitSidebar()
        {
            InitInspectors();
        }

        protected TreeNode GetSelectedLocationTreeNode()
        {
            Entity.InternalLocation loc = GetSelectedLocation();
            foreach (TreeNode node in ComponentsList.Nodes)
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

        private void ComponentViewModeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComponentsList.Nodes.Clear();
            BuildLocationList();
        }

        public void AddSystemsToNode(IEnumerable<BaseSystem> systemList, TreeNode root, int locID)
        {
            foreach (BaseSystem system in systemList)
            {
                if (system.LocationID != locID)
                    continue;

                TreeNode node = new TreeNode(system.Name);
                node.Tag = system;
                root.Nodes.Add(node);
            }
        }

        protected TreeNode AddConnectionNode(Entity.InternalLocation.ConnectionInfo connection, TreeNode locNode)
        {
            if (locNode == null)
                return null;

            TreeNode node = new TreeNode("To " + (connection.TargetIndex >= 0 ? TheEntity.Locations[connection.TargetIndex].Name : "Unknown"));
            node.Tag = connection;
            node.ImageIndex = 2;
            locNode.Nodes.Add(node);

            return node;
        }

        protected void AddConnectionNodes(Entity.InternalLocation loc, TreeNode locNode)
        {
            foreach (Entity.InternalLocation.ConnectionInfo connection in loc.Connections)
                AddConnectionNode(connection, locNode);
        }

        public void BuildLocationList()
        {
            foreach (Entity.InternalLocation loc in TheEntity.Locations)
            {
                TreeNode node = new TreeNode(loc.ToString());
                node.Tag = loc;
                node.ImageIndex = 11;
                ComponentsList.Nodes.Add(node);

                AddSystemsToNode(TheEntity.Engines, node, loc.Index);
                AddSystemsToNode(TheEntity.StorageSystems, node, loc.Index);
                AddSystemsToNode(TheEntity.FluidTanks, node, loc.Index);
                AddSystemsToNode(TheEntity.PropulsionSystems, node, loc.Index);
                AddSystemsToNode(TheEntity.NavigationSystems, node, loc.Index);
                AddSystemsToNode(TheEntity.DefensiveSystems, node, loc.Index);
                AddSystemsToNode(TheEntity.MedicalSystems, node, loc.Index);
                AddSystemsToNode(TheEntity.LifeSupportDistrobutions, node, loc.Index);
                AddSystemsToNode(TheEntity.LifeSupportRecyclers, node, loc.Index);
                AddSystemsToNode(TheEntity.Hangars, node, loc.Index);
                AddSystemsToNode(TheEntity.Sensors, node, loc.Index);
                AddSystemsToNode(TheEntity.Transporters, node, loc.Index);
                AddSystemsToNode(TheEntity.TractorBeams, node, loc.Index);
                AddSystemsToNode(TheEntity.Computers, node, loc.Index);
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation location = new Entity.InternalLocation();
            location.Name = "New Location";
            location.Index = TheEntity.Locations.Count;
            TheEntity.Locations.Add(location);

            TreeNode node = new TreeNode(location.ToString());
            node.Tag = location;
            ComponentsList.Nodes.Add(node);
            ComponentsList.SelectedNode = node;
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
            ComponentsList.Nodes.Add(node);
            ComponentsList.SelectedNode = node;
        }

        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation currentLoc = GetSelectedLocation();
            if (currentLoc == null)
                return;

            Entity.InternalLocation.ConnectionInfo con = new Entity.InternalLocation.ConnectionInfo();
            currentLoc.Connections.Add(con);

            ComponentsList.SelectedNode = AddConnectionNode(con, GetSelectedLocationTreeNode());
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
                ComponentsList.SelectedImageIndex = ComponentsList.SelectedNode.ImageIndex;

            if (ComponentsList.SelectedNode != null)
                LoadInspector(ComponentsList.SelectedNode.Tag);
            else
                InspectorArea.Controls.Clear();
            Draw();
        }

    }
}
