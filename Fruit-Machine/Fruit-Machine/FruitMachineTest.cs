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
        public void No_Match_Reels_Return_0()
        {
            var reel = new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            GivenReels(reel, reel, reel);
            GivenSpins(1, 2, 3);
            SpinScoreShouldBe(0);
        }

        [Test]
        public void Three_Wild_Return_100()
        {
            var reel = new[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            GivenReels(reel, reel, reel);
            GivenSpins(0, 0, 0);
            SpinScoreShouldBe(100);
        }

        [Test]
        public void Two_King_Return_3()
        {
            var reel1 = new[] { "King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild" };
            var reel2 = new[] { "Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King" };
            var reel3 = new[] { "Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell" };

            GivenReels(reel1, reel2, reel3);
            GivenSpins(0, 0, 1);

            SpinScoreShouldBe(3);
        }


        [Test]
        public void Two_Bell_Return_8()
        {
            var reel1 = new[] { "King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild" };
            var reel2 = new[] { "Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King" };
            var reel3 = new[] { "Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell" };

            GivenReels(reel1, reel2, reel3);
            GivenSpins(0, 0, 9);

            SpinScoreShouldBe(8);
        }


        private void GivenReels(string[] reel1, string[] reel2, string[] reel3)
        {
            _reels = new List<string[]> { reel1, reel2, reel3 };
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