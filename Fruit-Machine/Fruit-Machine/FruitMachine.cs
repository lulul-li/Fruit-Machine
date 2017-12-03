using System.Collections.Generic;

namespace Fruit_Machine
{
    public class FruitMachine
    {
        private Dictionary<string, int> score=new Dictionary<string, int>()
        {
            {"Wild",100 },
            {"Star",90 },
            {"Bell",80 },
            {"Shell",70 },
            {"Seven",60 },
            {"Cherry",50 },
            {"Bar",40 },
            {"King",30 },
            {"Queen",20 },
            {"Jack",10 },
        };

        public int Fruit(List<string[]> reels, int[] spins)
        {
            if (ThreeOfTheSame(reels, spins))
            {
                return score[reels[0][spins[0]]];
            }

            return 0;
        }

        private static bool ThreeOfTheSame(List<string[]> reels, int[] spins)
        {
            return reels[0][spins[0]] == reels[1][spins[1]] && reels[0][spins[0]] == reels[1][spins[2]];
        }
    }
}