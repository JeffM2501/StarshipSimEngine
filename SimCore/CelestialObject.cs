using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore
{
    public class CelestialObject : Entity
    {
        public enum Categories
        {
            Unknown = 0,
            Star,
            BlackHole,
            ParticleCloud,
            SpacialWarp,
            Planet,
            Moon,
            Nova,
        }
        public Categories Category = Categories.Unknown;
        public bool Charted = false;

        public double Mass = 0;
        public double Temperature = 0;

        public enum RaditionTypes
        {
            None = 0,
            Visible,
            Radio,
            Alpha,
            Beta,
            Gamma,
            XRay,
        }

        public RaditionTypes Radioactivity = RaditionTypes.None;
        public double RadiationIntensity = 0;

        public LifeSignData Life = new LifeSignData();
    }
}
