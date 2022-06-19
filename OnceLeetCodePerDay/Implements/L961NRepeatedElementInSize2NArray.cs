using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L961NRepeatedElementInSize2NArray
{
    public int RepeatedNTimes(int[] nums)
    {
        var expectedTimes = nums.Length / 2;
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums.Count(x => x == nums[i]) == expectedTimes)
            {
                return nums[i];
            }
        }

        throw new NotSupportedException();
        //return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
    }
}