using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimCore.Data;
using SimCore.Actors;

namespace SimCore.Entities
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

        public CelestialObject()
        {
            EntityType = Entity.EntityTypes.Celestial;
        }
    }

    public class Planet : CelestialObject
    {
        public List<Person> Population = new List<Person>();

        public Planet() : base()
        {
            Category = Categories.Planet;
        }
    }
}
