using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Library_Test
{
    [TestClass]
    public class YieldReturnTests
    {
        public class BandMembers
        {
            public System.Collections.Generic.IEnumerable<BandMember> NextMember
            {
                get
                {
                    yield return new BandMember { Name = "Lil' Sassy" };
                    yield return new BandMember { Name = "Robbie Boyd" };
                    yield return new BandMember { Name = "Ben Wagner" };
                    yield return new BandMember { Name = "Jason Brown" };
                    yield return new BandMember { Name = "Skeedaddle" };
                }
            }
        }

        public class BandMember
        {
            public string Name { get; set; }
        }

        [TestMethod]
        public void YieldReturnTest()
        {
            int count = 0;
            var members = new BandMembers();

            foreach(BandMember member in members.NextMember)
            {
                count++;
            }

            Assert.AreEqual(5, count);
        }
    }
}
