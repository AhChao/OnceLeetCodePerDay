using System;

namespace OnceLeetCodePerDay.Implements;

public class L2006CountNumberOfPairsWithAbsoluteDifferenceK
{
    public int CountKDifference(int[] nums, int k)
    {
        var result = 0;

        for(var i = 0; i < nums.Length; i++)
        {
            for(var j = i; j < nums.Length; j++)
            {
                if(Math.Abs(nums[i] - nums[j]) == k)
                {
                    result++;
                }
            }
        }

        return result;
    }
}