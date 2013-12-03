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
            PlanetaryBody,
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
        public enum SizeClasses
        {
            Unknown = 0,
            Asteroid,
            Moon,
            Dwarf,
            TerestrialSmall,
            TerestrialMedium,
            TerestrialLarge,
            IceGiant,
            GasGiant,
            GasSuperGiant,
        }
        public SizeClasses SizeClass = SizeClasses.Unknown;

        public enum HabitatClasses
        {
            Unknown = 0,
            ClassD, // airless moon or planetoid
            ClassH, // unstable atmosphere for oxygen based organic life
            ClassJ, // Hydrocarbon Gas Giant similar to Jupiter
            ClassK, // Low pressure world, habitable with pressure domes
            ClassL, // Marginally habitable, non-nitrogen based noble gas, 
            ClassM, // Baseline habitation, earth like
            ClassN, // sulfuric atmosphere
            ClassT, // Other uninhabitable
            ClassY, // Special "demon" classification for exotic planets
        }
        public HabitatClasses HabitatClass = HabitatClasses.Unknown;

        public List<Person> Population = new List<Person>();
        public double OribitRadius = 0;

        public Planet() : base()
        {
            Category = Categories.PlanetaryBody;
        }
    }
}
