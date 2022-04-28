using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1431KidsWithTheGreatestNumberOfCandies
{
    public bool[] KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandiesBeforeGive = candies.Max(x => x);
        return candies.Select(x => x + extraCandies >= maxCandiesBeforeGive).ToArray();
    }
}