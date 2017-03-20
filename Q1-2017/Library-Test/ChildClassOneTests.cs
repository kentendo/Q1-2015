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
        public void ChildMethodTest()
        {
            MethodInfo method = typeof(ChildClassOne).GetMethod("ChildMethod");
            Assert.AreEqual(method.DeclaringType.FullName, "Library.ChildClassOne");
        }

        [TestMethod()]
        public void ChildBaseMethodTest()
        {
            MethodInfo method = typeof(ChildClassOne).GetMethod("BaseMethod");
            Assert.AreEqual(method.DeclaringType.FullName, "Library.BaseClass");
        }

        [TestMethod()]
        public void ChildHiddenBaseMethodTest()
        {
            MethodInfo method = typeof(ChildClassOne).GetMethod("HiddenBaseMethod");
            Assert.AreEqual(method.DeclaringType.FullName, "Library.ChildClassOne");

            ChildClassOne cc = new ChildClassOne();
            Assert.AreEqual(cc.HiddenBaseMethod(), "ChildClassOne.HiddenBaseMethod");
        }

        [TestMethod()]
        public void ChildNewBaseMethodTest()
        {
            MethodInfo method = typeof(ChildClassOne).GetMethod("NewBaseMethod");
            Assert.AreEqual(method.DeclaringType.FullName, "Library.ChildClassOne");

            ChildClassOne cc = new ChildClassOne();
            Assert.AreEqual(cc.NewBaseMethod(), "ChildClassOne.NewBaseMethod");
        }

        [TestMethod()]
        public void ChildVirtualBaseMethodTest()
        {
            MethodInfo method = typeof(ChildClassOne).GetMethod("VirtualBaseMethod");
            Assert.AreEqual(method.IsVirtual, true);
        }

    }
}