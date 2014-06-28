using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShipSystems;

namespace CoolantTest
{
    public partial class Form1 : Form
    {
        SampleShip Ship = new SampleShip();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ship.Setup();

            foreach (ShipSystem system in Ship.Systems)
            {
                ShipSystemInspector inspector = new ShipSystemInspector(system);
                ShipSystems.Controls.Add(inspector);
            }

            for (int i = 0; i < Ship.Cooler.Reservoirs.Count; i++)
                ReservoirsContainer.Controls.Add(new ResevoirInspector(Ship.Cooler, i));

            CoolantBar.Maximum = (int)Ship.Cooler.MaxCoolant;
            CoolantBar.Minimum = 0;

            TempBar.Maximum = (int)Ship.Cooler.NominalTemp * 3;
            TempBar.Minimum = 0;

            HeatSinkFactor.Value = (decimal)Ship.Cooler.HeatSyncRemovalFactor;

            DoUpdate();
        }

        public void DoUpdate()
        {
            CoolantBar.Value = (int)Ship.Cooler.TotalCoolant;
            CoolantValue.Text = Ship.Cooler.TotalCoolant.ToString();

            TempBar.Value = (int)Ship.Cooler.CurrentTemp;
            TempValue.Text = Ship.Cooler.CurrentTemp.ToString();

            foreach (ShipSystemInspector i in ShipSystems.Controls)
                i.DoUpdate();

            foreach (ResevoirInspector i in ReservoirsContainer.Controls)
                i.DoUpdate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HeatSinkFactor_ValueChanged(object sender, EventArgs e)
        {
            Ship.Cooler.HeatSyncRemovalFactor = (float)HeatSinkFactor.Value;
        }

    }
}
