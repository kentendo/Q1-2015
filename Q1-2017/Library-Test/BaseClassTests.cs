using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests
{
    [TestClass()]
    public class BaseClassTests
    {
        [TestMethod()]
        public void GetFalseTest()
        {
            BaseClass bc = new BaseClass();
            Assert.AreEqual(bc.GetFalse(), false);
        }

        [TestMethod()]
        public void GetTrueTest()
        {
            BaseClass bc = new BaseClass();
            Assert.AreEqual(bc.GetTrue(), true);
        }
    }
}