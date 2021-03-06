﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using OpenTK.Graphics;

using SimCore;
using SimCore.Entities;
using SimCore.Data;
using SimCore.Data.Systems;
using SimCore.Actors;

using EntityBuilder.Inspectors;
using OpenTK;

namespace EntityBuilder
{
    public partial class MainForm : Form
    {
        Entity TheEntity = null;
        FileInfo DocumentFile = null;

        protected bool DocDirty = false;

        public CelestialObject GetCelestial() { return TheEntity as CelestialObject; }
        public StarShip GetStarShip() { return TheEntity as StarShip; }
        public Planet GetPlanet() { return TheEntity as Planet; }

        private static MainForm CurrentWindow = null;
        public static void SetCurrentDocDirty()
        {
            if (CurrentWindow != null)
                CurrentWindow.Dirty();
        }

        public MainForm()
        {
            CurrentWindow = this;
            InitializeComponent();
            SetUpMRU();
            Visualisation.Resize += new EventHandler(Visualisation_Resize);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitGUI();
            InitSidebar();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DocDirty)
            {
                if (MessageBox.Show(this, "There are unsaved changes, do you wish to save before closing?", "Save changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
            }
        }

        protected void EntityChanged()
        {
            this.Text = TheEntity.Name;
            BuildLocationList();
            SetupRendering();
        }

        public void Clean()
        {
            this.Text = TheEntity.Name;
            DocDirty = false;
            Draw();
        }

        public void Dirty()
        {
            if (!DocDirty)
                this.Text = TheEntity.Name + "*";

            DocDirty = true;

            Draw();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setAllTraversalSpeedsToSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entity.InternalLocation loc = GetSelectedLocation();
            if (loc == null)
                return;

            double speed = loc.TraversalSpeed;

            foreach(Entity.InternalLocation l in TheEntity.Locations)
                l.TraversalSpeed = speed;

            LoadInspector(ComponentsList.SelectedNode.Tag);
            Dirty();
        }
    }
}
