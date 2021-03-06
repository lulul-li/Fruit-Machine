﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Fruit_Machine
{
    public class FruitMachine
    {
        private Dictionary<string, int> Scoring=new Dictionary<string, int>()
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
                return GetScore(reels, spins);
            }
            if (TwoOfTheSame(reels, spins))
            {
                if (OneWild(reels, spins))
                {
                   return GetScore(reels, spins) / 5;
                }
                return GetScore(reels, spins) / 10; ;
            }

            return 0;
        }

        private static bool OneWild(List<string[]> reels, int[] spins)
        {
            return reels[0][spins[0]] == "Wild" || reels[1][spins[1]] == "Wild"|| reels[2][spins[2]] == "Wild";
        }

        private int GetScore(List<string[]> reels, int[] spins)
        {
            return Scoring[reels[0][spins[0]]];
        }

        private static bool TwoOfTheSame(List<string[]> reels, int[] spins)
        {
            return reels[0][spins[0]] == reels[1][spins[1]] || reels[0][spins[0]] == reels[1][spins[2]] || reels[0][spins[1]] == reels[1][spins[2]];
        }

        private static bool ThreeOfTheSame(List<string[]> reels, int[] spins)
        {
            return reels[0][spins[0]] == reels[1][spins[1]] && reels[0][spins[0]] == reels[1][spins[2]];
        }
    }
}