using System.Collections.Generic;
using System.Linq;

namespace Fruit_Machine
{
    public class FruitMachine1
    {
        private readonly Dictionary<string, int> _pointLookup = new Dictionary<string, int>()
        {
            {"Star",9 },
            {"Bell",8 },
            {"King", 3},
            {"Wild", 10},
        };

        private readonly Dictionary<int, int> _oddsLookup = new Dictionary<int, int>()
        {
            { 1,0},
            { 2,1},
            { 3,10},
        };

        public double fruit(List<string[]> reels, int[] spins)
        {
            var fruitIcon = GetMostCountIcon(reels, spins);

            return GetScore(fruitIcon);
        }

        private int GetScore(FruitIcon fruitIcon)
        {
            return _pointLookup[fruitIcon.Name] * _oddsLookup[fruitIcon.Count];
        }

        private static FruitIcon GetMostCountIcon(List<string[]> reels, int[] spins)
        {
            var spinResult = spins.Select((c, r) => reels[r][c]).ToList();
            return spinResult.GroupBy(x => x).Select(x => new FruitIcon
                {
                    Name=x.Key,
                    Count = x.Count()
                }
            ).OrderByDescending(x => x.Count).First();
        }
    }
}