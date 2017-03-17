using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass");
        }

        public string BaseMethod()
        {
            return "BaseClass.BaseMethod";
        }

        public string HiddenBaseMethod()
        {
            return "BaseClass.HiddenBaseMethod";
        }

        virtual public string OverrideBaseMethod()
        {
            return "BaseClass.OverrideBaseMethod";
        }


        public bool GetTrue()
        {
            Console.WriteLine("BaseClass.GetTrue");
            return true;
        }

        public bool GetFalse()
        {
            Console.WriteLine("BaseClass.GetFalse");
            return false;
        }

    }
}
