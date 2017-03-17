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
    public class ChildClassOneTests
    {
        [TestMethod()]
        public void GetTrueTest()
        {
            MethodInfo info = new MethodInfo();
            Assert.Fail();
        }
    }
}