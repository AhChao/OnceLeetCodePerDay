using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1913MaximumProductDifferenceBetweenTwoPairs
{
    public int MaxProductDifference(int[] nums)
    {
        var orderByDescending = nums.OrderByDescending(x => x).ToList();
        return orderByDescending[0] * orderByDescending[1] - orderByDescending[^1] * orderByDescending[^2];
    }
}