using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimCore.Actors;

namespace SimCore.Entities
{
    public class StarShip : Entity
    {
        public UInt64 OwnerFaction = UInt64.MaxValue;

        public enum StarShipSizeClasses
        {
            None = 0,
            Pod,
            Shuttle,
            Small,
            Medium,
            Large,
            Huge,
            Collosal,
        }
        public StarShipSizeClasses SizeClass = StarShipSizeClasses.None;

        public List<Person> Crew = new List<Person>();
        public List<Person> Passengers = new List<Person>();
        public List<Actor> Hostiles = new List<Actor>();

        public StarShip()
            : base()
        {
            EntityType = Entity.EntityTypes.Ship;
        }
    }
}
