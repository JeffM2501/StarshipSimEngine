using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace SimCore
{
    public class SystemInfo
    {
        public double OperationalStatus = 0;
        public double FunctionalStatus = 0;
        public double Reliability = 1.0;
        public double PowerConsumption = 0;
    }

    public class DefensiveSystem : SystemInfo
    {
        public enum DefensiveTypes
        {
            None = 0,
            Screens,
            Shields,
        }

        public DefensiveTypes DefensiveType = DefensiveTypes.None;
    }

    public class OffensiveSystem : SystemInfo
    {
        public enum OffensiveTypes
        {
            None = 0,
            Phasers,
            Torpedoes,
        }

        public OffensiveTypes OffensiveType = OffensiveTypes.None;

        public Vector3d Orientation = Vector3d.UnitX;
        public double Arc = 0;

        public double Buffer = 0;
    }
}
