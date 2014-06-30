using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using ShipSystems;

namespace CoolantTest
{
    public class SampleShip
    {
        public List<ShipSystem> Systems = new List<ShipSystem>();
        public CoolantSystem Cooler = new CoolantSystem();

        public static string ShipXMLFile = "Ship.xml";

        public static SampleShip Setup(DirectoryInfo dirToCheck)
        {
            FileInfo file = null;

            if (dirToCheck.Exists)
            {
                file = new FileInfo(Path.Combine(dirToCheck.FullName, ShipXMLFile));
                if (file.Exists)
                {
                    try
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(SampleShip));
                        FileStream fs = file.OpenRead();
                        SampleShip s = xml.Deserialize(fs) as SampleShip;
                        fs.Close();

                        if (s != null)
                            return HookUpShip(s);
                    }
                    catch(SystemException /*e*/)
                    {

                    }
                }
            }
           
            SampleShip ship = new SampleShip();
            ship.Systems.Clear();

            ship.Systems.Add(new ShipSystem("Thrusters"));
            ship.Systems.Add(new ShipSystem("LifeSupport",true,25));
            ship.Systems.Add(new ShipSystem("Sensors"));
            ship.Systems.Add(new ShipSystem("Missiles"));

            ShipSystem fSheilds = new ShipSystem("Forward Shields");
            fSheilds.MaxCoolantFlow = 200;
            fSheilds.NominalPower = 200;
            fSheilds.MaxPower = 400;
            fSheilds.ActivationHeat = 100;
            fSheilds.NominalTemp = 200;
            ship.Systems.Add(fSheilds);

            ShipSystem rSheilds = new ShipSystem("Rear Shields");
            rSheilds.MaxCoolantFlow = 200;
            rSheilds.NominalPower = 200;
            rSheilds.MaxPower = 400;
            rSheilds.ActivationHeat = 100;
            rSheilds.NominalTemp = 200;
            ship.Systems.Add(rSheilds);

            ShipSystem ftl = new ShipSystem("FTL");
            ftl.MaxCoolantFlow = 300;
            ftl.NominalPower = 1000;
            ftl.MaxPower = 5000;
            ftl.HeatDamageFactor = 0.01f;
            ftl.NominalTemp = 400;
            ftl.HeatGeneratedPerSecondPerPower = 0.05f;
            ship.Systems.Add(ftl);

            ShipSystem beams = new ShipSystem("Beams");
            beams.MaxCoolantFlow = 200;
            beams.NominalPower = 300;
            beams.MaxPower = 1000;
            beams.ActivationHeat = 100;
            beams.NominalTemp = 200;
            ship.Systems.Add(beams);

            ship.Cooler.MaxCoolant = 200;
            ship.Cooler.TotalCoolant = 100;
            ship.Cooler.AddReservoir(new CoolantSystem.Reservoir(100));
            ship.Cooler.AddReservoir(new CoolantSystem.Reservoir(100));

            if (dirToCheck.Exists)
                ship.Save(file);

            return HookUpShip(ship);
        }

        private static SampleShip HookUpShip(SampleShip ship)
        {
            ship.Cooler.ConnectedSystems = ship.Systems;

            float avalableCoolant = ship.Cooler.UnallocatedCoolant();

            foreach (ShipSystem system in ship.Systems)
            {
                system.SetDesiredPower(system.MinimumPower);
                ship.Cooler.SetSystemCoolant(system, avalableCoolant / ship.Systems.Count);
            }
            return ship;
        }

        public void Save(FileInfo file)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(SampleShip));
                FileStream fs = file.OpenWrite();
                xml.Serialize(fs,this);
                fs.Close();
            }
            catch(SystemException e)
            {

            }
        }

        public void Update(float time)
        {
            Cooler.Update(time);
            foreach (ShipSystem system in Systems)
                system.Update(time);
        }

        public void SetSystemDesiredCoolant(ShipSystem system, float value)
        {
            Cooler.SetSystemCoolant(system, value);
        }

        public void SetSystemDesiredPower(ShipSystem system, float value)
        {
            system.SetDesiredPower(value);
        }
    }
}
