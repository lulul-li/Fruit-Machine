using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Fruit_Machine
{
    [TestFixture]
    public class UnitTest1
    {
        private readonly FruitMachine _fruitMachine = new FruitMachine();
        private List<string[]> _reels;
        private int[] _spins;

        [SetUp]
        public void SetUp()
        {
            _reels = CreateReels();

        }

        [Test]
        public void NoMatchReels_Return_0()
        {
            GivenSpin(0, 1, 2);

            SpinScoreShouldBe(0);
        }

        private int[] GivenSpin(params int[] spinsNumber)
        {
            return _spins = spinsNumber;
        }

        private void SpinScoreShouldBe(int expected)
        {
            Assert.AreEqual(expected, _fruitMachine.Fruit(_reels, _spins));
        }

        [Test]
        public void ThreeWild_Return_100()
        {
            GivenSpin(0, 0, 0);
            SpinScoreShouldBe(100);
        }

        [Test]
        public void ThreeStar_Return_90()
        {
            GivenSpin(1, 1, 1);

            SpinScoreShouldBe(90);

        }
        [Test]
        public void TwoStar_Return_9()
        {
            GivenSpin(1, 1, 2);

            SpinScoreShouldBe(9);
        }

        [Test]
        public void TwoStar_OneWild_Return_18()
        {
            GivenSpin(1, 1, 0);

            SpinScoreShouldBe(18);

        }
        [Ignore("ignore")]
        [Test]
        public void TwoWild_Return_10()
        {
            GivenSpin(0, 0, 2);

            SpinScoreShouldBe(10);

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
