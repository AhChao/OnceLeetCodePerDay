using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1725NumberOfRectanglesThatCanFormTheLargestSquare
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        return rectangles.Select(x => x.Min()).GroupBy(x => x).OrderByDescending(x => x.Key).First().Count();
    }
}