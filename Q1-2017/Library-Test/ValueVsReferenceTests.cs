using Library;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_Test
{
    [TestClass]
    public class ValueVsReferenceTests
    {
        [TestMethod]
        public void ValueTypes()
        {
            int foo = 1;
            int bar = foo;
            bar += 1;
            Assert.AreEqual(foo, 1);
        }

        private void IncrememntNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            ReferenceType rf1 = new ReferenceType();
            ReferenceType rf2 = rf1;
            rf2.name = "Foo";
            Assert.AreEqual(rf1.name, "Foo");
        }
    }
}
