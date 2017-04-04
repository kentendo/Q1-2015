using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ImplicitClass : Interface1, Interface2
    {
        public string Method1()
        {
            return "ImplicitClass.Method1";
        }
    }
}
