using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L581ShortestUnsortedContinuousSubarray
{
    public int FindUnsortedSubarray(int[] nums)
    {
        var temp = nums.OrderBy(x => x).ToArray();
        var start = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            if(temp[i] != nums[i])
            {
                start = i;
                break;
            }
        }

        for(var i = nums.Length - 1; i >= 0; i--)
        {
            if(temp[i] != nums[i])
            {
                return i - start + 1;
            }
        }

        return 0;
    }
}