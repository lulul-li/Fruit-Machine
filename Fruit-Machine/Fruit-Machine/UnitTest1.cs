using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fruit_Machine
{
    [TestFixture]
    public class UnitTest1
    {
        private readonly FruitMachine _fruitMachine = new FruitMachine();

        [Test]
        public void NoMatchReels_Return_0()
        {
            var reels = CreateReels();
            var spins = new int[] { 0,1,2};
            Assert.AreEqual(0, _fruitMachine.Fruit(reels, spins));
        }

        [Test]
        public void ThreeWild_Return_100()
        {
            var reels = CreateReels();
            var spins = new int[] { 0, 0, 0 };
            Assert.AreEqual(100, _fruitMachine.Fruit(reels, spins));
        }

        [Test]
        public void ThreeStar_Return_90()
        {
            var reels = CreateReels();
            var spins = new int[] { 1, 1, 1 };
            Assert.AreEqual(90, _fruitMachine.Fruit(reels, spins));
        }
        [Test]
        public void TwoStar_Return_90()
        {
            var reels = CreateReels();
            var spins = new int[] { 1, 1, 0 };
            Assert.AreEqual(9, _fruitMachine.Fruit(reels, spins));
        }
        private static List<string[]> CreateReels()
        {
            return new List<string[]> {
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" },
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" },
                new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" }
            };
        }
    }
}
