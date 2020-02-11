using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<ICraftable> craftable)
        {
            Production newProduction = new Production(craftable);
            return newProduction;
        }

    }
}
