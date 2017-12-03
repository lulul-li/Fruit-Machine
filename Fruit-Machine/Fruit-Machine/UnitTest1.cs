using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fruit_Machine
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void NoMatchReels_Return_0()
        {
            var reels = new List<string[]> {
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" },
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" },
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" }
            };
            var spins = new int[] { 0,1,2};
            Assert.AreEqual(0, Fruit(reels, spins));
        }

        [Test]
        public void ThreeWild_Return_100()
        {
            var reels = new List<string[]> {
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" },
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" },
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" }
            };
            var spins = new int[] { 0, 0, 0 };
            Assert.AreEqual(100, Fruit(reels, spins));
        }

        private int Fruit(List<string[]> reels, int[] spins)
        {
            return 0;
        }
    }
}
