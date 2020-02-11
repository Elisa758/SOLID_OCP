using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP
{
    public class Production
    {
        IEnumerable<ICraftable> Craftables{ get; }

        public Production(IEnumerable<ICraftable> manyCraftable)
        {
            Craftables = manyCraftable;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (ICraftable craftable in Craftables)
            {
                description += "\t" + craftable.Type;
            }
            return description;
        }
    }
}
