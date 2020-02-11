using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_OCP
{
    public class Metal : ICraftable
    {
        public string Type
        {
            get
            {
                return "Metal";
            }
        }
    }
}
