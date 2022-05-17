using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L561ArrayPartitionI
{
    public int ArrayPairSum(int[] nums)
    {
        return nums.OrderBy(x => x).Where((_, index) => index % 2 == 0).Sum();
    }
}