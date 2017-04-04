using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class AssemblyClass
    {
        public string BaseClassInternalMethod()
        {
            BaseClass bc = new BaseClass();
            return bc.InternalMethod();
        }

    }
}
