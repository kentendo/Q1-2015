using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BaseClass : AbstractClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass");
        }

        override public string AbstractMethod()
        {
            return "BaseClass.AbstractMethod";
        }

        public string BaseMethod()
        {
            return "BaseClass.BaseMethod";
        }

        public string NewBaseMethod()
        {
            return "BaseClass.NewBaseMethod";
        }

        public string HiddenBaseMethod()
        {
            return "BaseClass.HiddenBaseMethod";
        }

        virtual public string VirtualBaseMethod()
        {
            return "BaseClass.VirtualBaseMethod";
        }
    }
}
