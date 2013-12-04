using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

using SimCore.Data.Systems;

namespace SimCore.Utilities
{
    public static class Utils
    {
        public static List<Type> GetSystemTypes()
        {
            List<Type> types = new List<Type>();

            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.IsSubclassOf(typeof(BaseSystem)))
                    types.Add(t);
            }

            types.Add(typeof(BaseSystem));

            return types;
        }
    }
}
