using System.Collections.Generic;
using NUnit.Framework;

namespace Fruit_Machine
{
    [TestFixture]
    public class FruitMachineTest
    {
        private FruitMachine1 _fruitMachine;
        private List<string[]> _reels;
        private int[] _spins;

        [SetUp]
        public void SetUp()
        {
            _fruitMachine = new FruitMachine1();
        }

        [Test]
        public void NoMatchReels_Return_0()
        {
            var reel = new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            GivenReels(reel);
            GivenSpins(1, 2, 3);
            SpinScoreShouldBe(0);
        }

        [Test]
        public void ThreeWild_Return_100()
        {
            var reel = new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            GivenReels(reel);
            GivenSpins(0, 0, 0);
            SpinScoreShouldBe(100);
        }

        private void GivenReels(string[] reel)
        {
            _reels = new List<string[]> { reel, reel, reel };
        }

        private void GivenSpins(params int[] spins)
        {
            _spins = spins;
        }

        private void SpinScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _fruitMachine.fruit(_reels, _spins));
        }
    }
}