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

namespace EntityBuilder
{
    partial class MainForm
    {
        protected Entity.InternalLocation GetSelectedLocation()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            Entity.InternalLocation loc = ComponentsList.SelectedNode.Tag as Entity.InternalLocation;

            if (loc != null)
                return loc;

            BaseSystem sys = ComponentsList.SelectedNode.Tag as BaseSystem;
            if (sys == null || sys.LocationID < 0 || sys.LocationID >= TheEntity.Locations.Count)
                return null;

            return TheEntity.Locations[sys.LocationID];
        }

        protected BaseSystem GetSelectedSystem()
        {
            if (ComponentsList.SelectedNode == null)
                return null;

            Entity.InternalLocation loc = ComponentsList.SelectedNode.Tag as Entity.InternalLocation;

            if (loc != null)
                return null;

            BaseSystem sys = ComponentsList.SelectedNode.Tag as BaseSystem;
            if (sys == null || sys.LocationID < 0 || sys.LocationID >= TheEntity.Locations.Count)
                return null;

            return sys;
        }

        public bool ViewByLocation()
        {
            return ComponentViewModeList.SelectedIndex == 0;
        }

        private void ComponentViewModeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComponentsList.Nodes.Clear();

            if (ViewByLocation())
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

        public void BuildLocationList()
        {
            foreach (Entity.InternalLocation loc in TheEntity.Locations)
            {
                TreeNode node = new TreeNode(loc.ToString());
                node.Tag = loc;
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

            if (ViewByLocation())
            {
                TreeNode node = new TreeNode(location.ToString());
                node.Tag = location;
                ComponentsList.Nodes.Add(node);
                ComponentsList.SelectedNode = node;
            }
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

            if (ViewByLocation())
            {
                TreeNode node = new TreeNode(location.ToString());
                node.Tag = location;
                ComponentsList.Nodes.Add(node);
                ComponentsList.SelectedNode = node;
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
            BaseSystem system = GetSelectedSystem();
            if (system != null)
            {

            }
            else
            {
                Entity.InternalLocation location = GetSelectedLocation();

                if (location != null)
                    LoadLocationInspector(location);
            }

            Draw();
        }

    }
}
