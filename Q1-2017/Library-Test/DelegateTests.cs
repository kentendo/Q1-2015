using Library;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_Test
{
    [TestClass]
    public class DelegateTests
    {
        public bool handler1Called = false;
        public bool handler2Called = false;

        void DelegateHandler1(string name)
        {
            handler1Called = true;
        }

        void DelegateHandler2(string name)
        {
            handler2Called = true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Delegate1 d1 = new Delegate1(DelegateHandler1);
            Delegate1 d2 = new Delegate1(DelegateHandler2);

            // add another delegate to the invocation list
            d1 += d2;

            d1("Kenny");

            Assert.IsTrue(handler1Called);
            Assert.IsTrue(handler2Called);
        }
    }
}
