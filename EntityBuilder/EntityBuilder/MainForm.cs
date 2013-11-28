using System;
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

            ComponentViewModeList.SelectedIndex = -1;
            ComponentViewModeList.SelectedIndex = 0;
            SetupRendering();
        }

        public void Dirty()
        {
            DocDirty = true;
            Draw();
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
