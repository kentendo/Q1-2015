using Library;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_Test
{
    [TestClass]
    public class ImplicitVsExplicitTests
    {
        [TestMethod]
        public void ImplicitTest()
        {
            ImplicitClass ic = new ImplicitClass();
            Interface1 i1 = (Interface1)ic;
            Interface2 i2 = (Interface2)ic;

            Assert.AreEqual("ImplicitClass.Method1", ic.Method1());
            Assert.AreEqual("ImplicitClass.Method1", i1.Method1());
            Assert.AreEqual("ImplicitClass.Method1", i2.Method1());
        }

        [TestMethod]
        public void ExplicitTest()
        {
            ExplicitClass ic = new ExplicitClass();
            Interface1 i1 = (Interface1)ic;
            Interface2 i2 = (Interface2)ic;

            Assert.AreEqual("ExplicitClass.Method1", ic.Method1());
            Assert.AreEqual("ExplicitClass.Interface1.Method1", i1.Method1());
            Assert.AreEqual("ExplicitClass.Interface2.Method1", i2.Method1());
        }
    }
}
