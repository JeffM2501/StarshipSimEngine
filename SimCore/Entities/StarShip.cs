﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimCore.Actors;

namespace SimCore.Entities
{
    public class StarShip : Entity
    {
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
    }
}
