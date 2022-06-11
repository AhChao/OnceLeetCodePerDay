using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1658MinimumOperationsToReduceXToZero
{
    public int MinOperations(int[] nums, int x)
    {
        var target = nums.Sum() - x;
        if(target < 0)
        {
            return -1;
        }

        if(target == 0)
        {
            return nums.Length;
        }

        var i = 0;
        var j = 0;
        var result = -1;
        var sum = 0;
        while(j < nums.Length)
        {
            sum += nums[j];
            if(sum < target)
            {
                j++;
            }
            else if(sum == target)
            {
                result = Math.Max(result, j - i + 1);
                j++;
            }
            else
            {
                while(sum > target)
                {
                    sum -= nums[i];
                    i++;
                }

                if(sum == target)
                {
                    result = Math.Max(result, j - i + 1);
                }

                j++;
            }
        }

        return result == -1 ? -1 : nums.Length - result;
    }
}