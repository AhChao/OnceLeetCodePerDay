using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1679MaxNumberOfKSumPairs
{
    public int MaxOperations(int[] nums, int k)
    {
        nums = nums.OrderBy(x => x).ToArray();
        var left = 0;
        var right = nums.Length - 1;
        var result = 0;
        while(left < right)
        {
            if(nums[left] + nums[right] > k)
            {
                right--;
            }
            else if(nums[left] + nums[right] < k)
            {
                left++;
            }
            else
            {
                result++;
                right--;
                left++;
            }
        }

        return result;
    }
}