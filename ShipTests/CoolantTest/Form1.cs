using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

using ShipSystems;

namespace CoolantTest
{
    public partial class Form1 : Form
    {
        SampleShip Ship = new SampleShip();

        private delegate void UpdateFunctionDef();

        private UpdateFunctionDef UpdateFunction;

        protected float LastUpdateTime = 0;
        protected Stopwatch Clock = new Stopwatch();


        public Form1()
        {
            InitializeComponent();
            UpdateFunction = new UpdateFunctionDef(DoUpdate);
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {
            Ship = SampleShip.Setup(new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath)));

            foreach (ShipSystem system in Ship.Systems)
            {
                ShipSystemInspector inspector = new ShipSystemInspector(system);
                inspector.SetCoolant += inspector_SetCoolant;
                inspector.SetPower += inspector_SetPower;
                inspector.Activate += inspector_Activate;

                ShipSystems.Controls.Add(inspector);
            }

            for (int i = 0; i < Ship.Cooler.Reservoirs.Count; i++)
                ReservoirsContainer.Controls.Add(new ResevoirInspector(Ship.Cooler, i));

            CoolantBar.Maximum = (int)Ship.Cooler.MaxCoolant;
            CoolantBar.Minimum = 0;

            UnallocatedCoolantBar.Maximum = CoolantBar.Maximum;
            UnallocatedCoolantBar.Minimum = 0;

            TempBar.Maximum = (int)Ship.Cooler.NominalTemp * 3;
            TempBar.Minimum = 0;

            HeatSinkFactor.Value = (decimal)Ship.Cooler.HeatSyncRemovalFactor;

            DoUpdate();

            Clock.Start();
            LastUpdateTime = Seconds();
            timer1.Start();
        }

        public float Seconds()
        {
            lock (Clock)
                return (float)(Clock.ElapsedMilliseconds * 0.001f);
        }

        void inspector_Activate(object sender, ShipSystemInspector.ShipSystemValueEventArgs e)
        {
            ShipSystemInspector inspector = sender as ShipSystemInspector;
            if (inspector == null || inspector.InspectedSystem == null)
                return;

            lock (Ship)
                inspector.InspectedSystem.Activate();
        }

        void inspector_SetPower(object sender, ShipSystemInspector.ShipSystemValueEventArgs e)
        {
            ShipSystemInspector inspector = sender as ShipSystemInspector;
            if (inspector == null || inspector.InspectedSystem == null)
                return;

            lock (Ship)
                Ship.SetSystemDesiredPower(inspector.InspectedSystem, e.Value);
        }

        void inspector_SetCoolant(object sender, ShipSystemInspector.ShipSystemValueEventArgs e)
        {
            ShipSystemInspector inspector = sender as ShipSystemInspector;
            if (inspector == null || inspector.InspectedSystem == null)
                return;

            lock (Ship)
                Ship.SetSystemDesiredCoolant(inspector.InspectedSystem, e.Value);
        }

        public void DoUpdate()
        {
            float seconds = Seconds();
            float delta = seconds - LastUpdateTime;
            LastUpdateTime = seconds;

            lock (Ship)
            {
                Ship.Update(delta);

                CoolantBar.Value = (int)Ship.Cooler.TotalCoolant;
                CoolantValue.Text = Ship.Cooler.TotalCoolant.ToString();

                TempBar.Value = (int)Ship.Cooler.CurrentTemp;
                TempValue.Text = Ship.Cooler.CurrentTemp.ToString();

                if (UnallocatedCoolantBar.Maximum != Ship.Cooler.TotalCoolantInAction())
                    UnallocatedCoolantBar.Maximum = (int)Ship.Cooler.TotalCoolantInAction();

                UnallocatedCoolantBar.Value = (int)Ship.Cooler.UnallocatedCoolant();

                CoolantInSystem.Text = Ship.Cooler.TotalCoolantInAction().ToString();
                UnAllocatedCoolantValue.Text = Ship.Cooler.UnallocatedCoolant().ToString();

                foreach (ShipSystemInspector i in ShipSystems.Controls)
                    i.DoUpdate();

                foreach (ResevoirInspector i in ReservoirsContainer.Controls)
                    i.DoUpdate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HeatSinkFactor_ValueChanged(object sender, EventArgs e)
        {
            lock(Ship)
                Ship.Cooler.HeatSyncRemovalFactor = (float)HeatSinkFactor.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(this.UpdateFunction);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void VentCoolant_Click(object sender, EventArgs e)
        {
            Ship.Cooler.TotalCoolant -= (float)CoolantToVent.Value;
        }

        public delegate void SystemInspectorEffector(ShipSystemInspector inspector, ShipSystem system);

        public void DoForEachSystem(SystemInspectorEffector func)
        {
            lock (Ship)
            {
                foreach (ShipSystemInspector i in ShipSystems.Controls)
                    func(i, i.InspectedSystem);

            }
        }

        private void ShutdownAll_Click(object sender, EventArgs e)
        {
            DoForEachSystem(delegate(ShipSystemInspector i, ShipSystem s) { i.SetDesiredPower(s.MinimumPower); });
        }

        private void NominalAll_Click(object sender, EventArgs e)
        {
            DoForEachSystem(delegate(ShipSystemInspector i, ShipSystem s) { i.SetDesiredPower(s.NominalPower); });
        }

        private void SplitCool_Click(object sender, EventArgs e)
        {
            float averageCool = 0;

            lock (Ship)
                averageCool = Ship.Cooler.TotalCoolantInAction() / Ship.Systems.Count;

            DoForEachSystem(delegate(ShipSystemInspector i, ShipSystem s) { i.SetDesiredCoolant(averageCool); });
        }

        private void BallanceCool_Click(object sender, EventArgs e)
        {
            float availCool = 0;
            float weightedTotal = 0;

            lock (Ship)
            {
                availCool = Ship.Cooler.TotalCoolantInAction();
                foreach (ShipSystemInspector i in ShipSystems.Controls)
                    weightedTotal += i.InspectedSystem.MaxCoolantFlow;
            }

            DoForEachSystem(delegate(ShipSystemInspector i, ShipSystem s) { i.SetDesiredCoolant((i.InspectedSystem.MaxCoolantFlow / weightedTotal) * availCool); });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float availCool = 0;
            float weightedTotal = 0;

            lock (Ship)
            {
                availCool = Ship.Cooler.TotalCoolantInAction();
                foreach (ShipSystemInspector i in ShipSystems.Controls)
                {
                    if (i.InspectedSystem.CurrentTemp > 0 || i.InspectedSystem.CurrentPower > 0)
                        weightedTotal += i.InspectedSystem.MaxCoolantFlow;
                }
                    
            }

            DoForEachSystem(delegate(ShipSystemInspector i, ShipSystem s) { i.SetDesiredCoolant((i.InspectedSystem.CurrentTemp > 0 || i.InspectedSystem.CurrentPower > 0) ? (i.InspectedSystem.MaxCoolantFlow / weightedTotal) * availCool : 0); });
        }

    }
}
