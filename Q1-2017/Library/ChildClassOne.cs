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

        public string ChildMethod()
        {
            return "ChildClassOne.ChildMethod";
        }

        public string HiddenBaseMethod()
        {
            return "ChildClassOne.HiddenBaseMethod";
        }

        new public string NewBaseMethod()
        {
            return "ChildClassOne.NewBaseMethod";
        }

        override public string VirtualBaseMethod()
        {
            return "ChildClassOne.HiddenBaseMethod";
        }
    }
}
