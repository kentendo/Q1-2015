using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ExplicitClass : Interface1, Interface2
    {

        public string Method1()
        {
            return "ExplicitClass.Method1";
        }

        string Interface1.Method1()
        {
            return "ExplicitClass.Interface1.Method1";
        }

        string Interface2.Method1()
        {
            return "ExplicitClass.Interface2.Method1";
        }

    }
}
