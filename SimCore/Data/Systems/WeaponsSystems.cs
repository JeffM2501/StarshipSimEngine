using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;
using SimCore.Actors;

namespace SimCore.Data.Systems
{
    public class OffensiveSystem : BaseSystem
    {
        public enum OffensiveTypes
        {
            None = 0,
            Beams,
            Torpedoes,
            Projectiles,
        }

        public OffensiveTypes OffensiveType = OffensiveTypes.None;

        public Quaternion Orientation = Quaternion.Identity;
        public double Arc = 0;


        public enum FireModes
        {
            Offline = 0,
            Targeted,
            Manual,
        }
        public bool AllowManual = false;
        public FireModes FireMode = FireModes.Offline;

        public UInt64 TargetID = 0;
        public Quaternion CurrentAim = Quaternion.Identity;
    }

    public class BeamProjector : OffensiveSystem
    {
        public double ChargeDecay = 0;
        public double NominalDischargeRate = 0;
        public double OverchargeHeatGenerated = 0;

        public double CurenShotPower = 1;
        public double CurrentShotTime = -1;

        public BeamProjector()
        {
            OffensiveType = OffensiveTypes.Beams;
            AllowManual = true;
        }
    }

    public class TorpedoLauncher : OffensiveSystem
    {
        public List<UInt64> Magazines = new List<UInt64>();

        public class ChargingTankInfo
        {
            public Torpedo.TorpedoTypes TorpedoType = Torpedo.TorpedoTypes.Unknown;
            public FluidTankSystem Tank = null;
        }
        public List<ChargingTankInfo> ChargingTanks = new List<ChargingTankInfo>();

        public List<Torpedo.TorpedoTypes> AcceptedTorpedoTypes = new List<Torpedo.TorpedoTypes>();

        public int TubeCount = 0;

        public List<Torpedo> LoadedTorpedoes = new List<Torpedo>();

        public virtual ChargingTankInfo GetTankForType(Torpedo.TorpedoTypes torpType)
        {
            return ChargingTanks.Find(delegate(ChargingTankInfo i) { return i.TorpedoType == torpType; });
        }

        public virtual bool AcceptTorpedoType(Torpedo.TorpedoTypes torpType)
        {
            if (!AcceptedTorpedoTypes.Contains(torpType))
                return false;

            ChargingTankInfo tank = GetTankForType(torpType);
            if (tank != null)
                return tank.Tank.Contents.CurrentCapacity > 0;

            return true;
        }
    }
}
