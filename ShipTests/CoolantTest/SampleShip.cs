using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShipSystems;

namespace CoolantTest
{
    public class SampleShip
    {
        public List<ShipSystem> Systems = new List<ShipSystem>();
        public CoolantSystem Cooler = new CoolantSystem();

        public void Setup()
        {
            Systems.Clear();

            Systems.Add(new ShipSystem("Thrusters"));
            Systems.Add(new ShipSystem("LifeSupport"));

            ShipSystem ftl = new ShipSystem("FTL");
            ftl.MaxCoolantFlow = 300;
            ftl.NominalPower = 1000;
            ftl.MaxPower = 5000;
            ftl.HeatDamageFactor = 0.01f;
            ftl.NominalTemp = 200;
            Systems.Add(ftl);

            ShipSystem beams = new ShipSystem("Beams");
            beams.MaxCoolantFlow = 200;
            beams.NominalPower = 300;
            beams.MaxPower = 1000;
            beams.ActivationHeat = 100;
            beams.NominalTemp = 200;
            Systems.Add(beams);


            Cooler.MaxCoolant = 200;
            Cooler.TotalCoolant = 100;
            Cooler.AddReservoir(new CoolantSystem.Reservoir(100));
            Cooler.AddReservoir(new CoolantSystem.Reservoir(100));

            Cooler.ConnectedSystems = Systems;
        }

        public void Update(float time)
        {
            Cooler.Update(time);
            foreach (ShipSystem system in Systems)
                system.Update(time);
        }
    }
}
