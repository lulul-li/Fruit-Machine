using System.Collections.Generic;
using System.Linq;

namespace Fruit_Machine
{
    public class FruitMachine1
    {
        private readonly Dictionary<int, int> _oddsLookup = new Dictionary<int, int>()
        {
            { 1,0},
            { 2,1},
            { 3,10},
        };

        private readonly Dictionary<string, int> _pointLookup = new Dictionary<string, int>()
        {
            {"Jack", 1},
            {"Queen", 2},
            {"King", 3},
            {"Bar", 4},
            {"Cherry", 5},
            {"Seven", 6},
            {"Shell", 7},
            {"Bell", 8},
            {"Star", 9},
            {"Wild", 10}
        };

        public double fruit(List<string[]> reels, int[] spins)
        {
            var spinResult = GetSpinResult(reels, spins);
            return GetScore(spinResult);
        }

        private static List<string> GetSpinResult(List<string[]> reels, int[] spins)
        {
            return spins.Select((c, r) => reels[r][c]).ToList();
        }

        private int GetScore(List<string> spinResult)
        {
            var fruitIcon = GetMostCountIcon(spinResult);
            var score = _pointLookup[fruitIcon.Name] * _oddsLookup[fruitIcon.Count];

            return ShouldDoubleScore(fruitIcon, spinResult)
                ? score * 2
                : score;
        }

        private static FruitIcon GetMostCountIcon(List<string> spinResult)
        {
            return spinResult.GroupBy(x => x).Select(x => new FruitIcon
            {
                Name = x.Key,
                Count = x.Count()
            }
            ).OrderByDescending(x => x.Count).First();
        }

        private static bool ShouldDoubleScore(FruitIcon fruitIcon, List<string> spinResult)
        {
            return fruitIcon.Count == 2 && fruitIcon.Name != "Wild" && spinResult.Any(x => x == "Wild");
        }
    }
}