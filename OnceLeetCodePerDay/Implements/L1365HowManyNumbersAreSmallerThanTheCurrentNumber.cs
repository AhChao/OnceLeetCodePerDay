using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1365HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var counting = nums.ToArray().OrderBy(x => x).ToArray();
        var result = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++)
        {
            result[i] = Array.IndexOf(counting, nums[i]);
        }

        return result;
        //One line in linq but may be slower than above one
        //return nums.Select(x => nums.Count(y => y < x)).ToArray();
    }
}