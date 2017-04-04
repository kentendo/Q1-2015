using System;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_Test
{
    [TestClass]
    public class ExtensionMethodsTests
    {
        [TestMethod]
        public void ExtensionMethod()
        {
            string foo = "bar";
            string result = foo.ConvertToTitleCase();

            Assert.AreEqual("Bar", result);
        }
    }
}
