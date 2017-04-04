using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SubClass : BaseClass
    {
        public string PublicProtectedMethod()
        {
            return this.ProtectedMethod();
        }
    }
}
