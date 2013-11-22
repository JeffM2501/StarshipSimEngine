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
        }

        public OffensiveTypes OffensiveType = OffensiveTypes.None;

        public Vector3d Orientation = Vector3d.UnitX;
        public double Arc = 0;
    }

    public class BeamProjector : OffensiveSystem
    {
        public double ChargeBuffer = 0;
        public double ChargeFactor = 0;

        public double ChargeDecay = 0;

        public double MaxDischarge = 0;
    }

    public class TorpedoLauncher : OffensiveSystem
    {
        public List<UInt64> Magazines = new List<UInt64>();
        public List<FluidTankSystem> ChargingTanks = new List<FluidTankSystem>();

        public int MaxiumLoad = 0;

        public List<Torpedo> LoadedTorpedoes = new List<Torpedo>();
    }
}
