using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ChildClassOne : BaseClass
    {
        public ChildClassOne()
        {
            Console.WriteLine("ChildClassOne");
        }

        public bool GetTrue()
        {
            Console.WriteLine("ChildClassOne.GetTrue");
            return true;
        }

        public bool GetFalse()
        {
            Console.WriteLine("ChildClassOne.GetFalse");
            return false;
        }
    }
}
