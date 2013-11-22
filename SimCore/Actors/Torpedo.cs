using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore.Actors
{
    public class Torpedo : Actor
    {
        public enum TorpedoTypes
        {
            Unknown = 0,
            Explosive,
            Photon,
            Quantum,
        }
        public TorpedoTypes TorpedoType = TorpedoTypes.Unknown;

        public double Charge = 0.0;
    }
}
