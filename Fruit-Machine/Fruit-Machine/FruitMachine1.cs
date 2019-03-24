using System.Collections.Generic;

namespace Fruit_Machine
{
    public class FruitMachine1
    {
        public double fruit(List<string[]> reels, int[] spins)
        {
            if (reels[0][spins[0]] == "Wild" && reels[1][spins[1]] == "Wild" && reels[2][spins[2]] == "Wild")
            {
                return 100;
            }

            return 0;
        }
    }
}