using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP
{
    public class Wood : ICraftable
    {
        public string Type
        {
            get
            {
                return "Wood";
            }
        }
    }
}
