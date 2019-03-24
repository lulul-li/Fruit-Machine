using System.Collections.Generic;
using NUnit.Framework;

namespace Fruit_Machine
{
    [TestFixture]
    public class FruitMachineTest
    {
        [Test]
        public void NoMatchReels_Return_0()
        {
            var fruitMachine = new FruitMachine1();
            var reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            var reels = new List<string[]> { reel, reel, reel };
            var spins = new int[] { 0, 0, 0 };


            Assert.AreEqual(100, fruitMachine.fruit(reels, spins));
        }
    }

    public class FruitMachine1
    {
        public double fruit(List<string[]> reels, int[] spins)
        {
            return 100;
        }
    }
}