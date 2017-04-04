using Library;
using System;
using System.Collections;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_Test
{
    [TestClass]
    public class ActivatorTests
    {
        [TestMethod]
        public void TestActivatorMethod()
        {
            Assembly testAssembly = Assembly.LoadFile("C:/git/Q1-2017-VS2015/Q1-2017/Library-Test/bin/Debug/Library.dll");
            Type baseClassType = testAssembly.GetType("Library.BaseClass");
            Type subClassType = testAssembly.GetType("Library.SubClass");
            Type assemblyClassType = testAssembly.GetType("Library.AssemblyClass");

            object bc = Activator.CreateInstance(baseClassType);
            object sc = Activator.CreateInstance(subClassType);
            object ac = Activator.CreateInstance(assemblyClassType);

            MethodInfo[] methods = baseClassType.GetMethods();
            System.Collections.Generic.IEnumerable<MethodInfo> runtimeMethods = baseClassType.GetRuntimeMethods();

            MethodInfo publicMethod = baseClassType.GetMethod("BaseMethod");
            MethodInfo privateMethod = baseClassType.GetMethod("PrivateMethod");
            MethodInfo protectedMethod = baseClassType.GetMethod("ProtectedMethod");
            MethodInfo internalMethod = baseClassType.GetMethod("InternalMethod");

            Assert.IsNotNull(publicMethod);
            Assert.IsNull(privateMethod);
            Assert.IsNull(protectedMethod);
            Assert.IsNull(internalMethod);


          // Assert.AreEqual("BaseClass.ProtectedMethod", sc.PublicProtectedMethod());


            Console.WriteLine("hi");
        }
    }
}
