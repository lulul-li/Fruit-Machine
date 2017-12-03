using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fruit_Machine
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {

            var reels = new List<string[]> { };
            var spins=new int[]{};
            Assert.AreEqual(0,Fruit(reels, spins));
        }

        private int Fruit(List<string[]> reels, int[] spins)
        {
            throw new NotImplementedException();
        }
    }
}
