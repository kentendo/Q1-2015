using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass()]
    public class BaseClassTests
    {

        [TestMethod()]
        public void BaseMethodTest()
        {
            MethodInfo method = typeof(BaseClass).GetMethod("BaseMethod");
            Assert.AreEqual(method.DeclaringType.FullName, "Library.BaseClass");
        }
    }
}