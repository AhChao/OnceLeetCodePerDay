using System;

namespace OnceLeetCodePerDay.Implements;

public class L300LongestIncreasingSubsequence
{
    public int LengthOfLIS(int[] nums)
    {
        var dp = new int[nums.Length];
        var len = 0;
        foreach(var num in nums)
        {
            var index = Array.BinarySearch(dp, 0, len, num);
            if(index < 0)
            {
                index = -(index + 1);
            }

            dp[index] = num;
            if(index == len)
            {
                len++;
            }
        }

        return len;
    }
}