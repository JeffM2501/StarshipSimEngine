using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenTK;

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

        public double MaxCharge = 0.0;
        public double Charge = 0.0;

        public double ChargeRate = -1;

        public double DamageFactor = 0.0;

        public double Acceleration = 0.0;
        public double RotationSpeed = 0.0;

        public double Speed = 0.0;

        public bool UseFTLScale = false;

        public Quaternion Orientation = Quaternion.Identity;
    }
}
