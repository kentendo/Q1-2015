using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ChildClassTwo : BaseClass
    {
        public ChildClassTwo()
        {
            Console.WriteLine("ChildClassTwo");
        }

        public bool GetTrue()
        {
            Console.WriteLine("ChildClassTwo.GetTrue");
            return true;
        }

        public bool GetFalse()
        {
            Console.WriteLine("ChildClassTwo.GetFalse");
            return false;
        }
    }
}
