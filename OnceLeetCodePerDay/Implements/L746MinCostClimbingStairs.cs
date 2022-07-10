using System;

namespace OnceLeetCodePerDay.Implements;

public class L746MinCostClimbingStairs
{
    public int MinCostClimbingStairs(int[] cost)
    {
        if(cost.Length <= 1)
        {
            return 0;
        }

        var total = 0;
        var dp = new int[cost.Length];
        for(var i = 0; i < cost.Length; i++)
        {
            if(i <= 1)
            {
                dp[i] = cost[i];
            }
            else
            {
                dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
            }
        }

        return Math.Min(dp[cost.Length - 1], dp[cost.Length - 2]);
    }
}