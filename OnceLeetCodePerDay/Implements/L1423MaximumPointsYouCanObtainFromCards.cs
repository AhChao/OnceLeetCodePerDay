using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1423MaximumPointsYouCanObtainFromCards
{
    public int MaxScore(int[] cardPoints, int k)
    {
        var sum = cardPoints.Sum();
        var windowSize = cardPoints.Length - k;
        var minInWindow = cardPoints.Take(windowSize).Sum();
        var sumBetween = minInWindow;
        for(var i = 1; i < cardPoints.Length - windowSize + 1; i++)
        {
            sumBetween = sumBetween - cardPoints[i - 1] + cardPoints[i + windowSize - 1];
            minInWindow = minInWindow > sumBetween ? sumBetween : minInWindow;
        }

        return sum - minInWindow;
    }
}