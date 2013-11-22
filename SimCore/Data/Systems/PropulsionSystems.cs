using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCore.Data.Systems
{
    public class PropulsionSystem : BaseSystem
    {
        public enum PropulsionTypes
        {
            Unknown = 0,
            Reaction,
            Impulse,
            Warp,
            Jump,
        }
        public PropulsionTypes PropulsionType = PropulsionTypes.Unknown;

        public enum ThrustPhysicsType
        {
            Newtonian = 0,  // has inertia, moves through all points in path
            ConditionalFTL, // no inertia, return to previous Newtonian speed when disengaged, moves through all points in path
            SpatialFolding, // no inertia, return to previous Newtonian speed when disengaged, does not traverse points allong path
        }
        public ThrustPhysicsType PhysicsType = ThrustPhysicsType.Newtonian;

        public bool UseFTLScale = false;

        public double ChargeBuffer = 0;
        public double MaxChargeRate = 0;
        public double PowerToThrustFactor = 0;

        public double MaxAcceleration = 0;
        public double MaxSpeed = 0;

        public List<GenerationSystem.FuelConsumption> FuelConsumptions = new List<GenerationSystem.FuelConsumption>();
    }

}
