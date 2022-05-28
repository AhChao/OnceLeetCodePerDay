using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L474OnesAndZeroes
{
    public int FindMaxForm(string[] strs, int m, int n)//Tabulation
    {
        var dp = new int[m + 1, n + 1]; //means remain 0, remain 1 max counting
        foreach(var str in strs)
        {
            var countOfZero = str.Count(x => x == '0');
            var countOfOne = str.Count(x => x == '1');
            for(int i = 0; i + countOfZero <= m; i++)
            {
                for(int j = 0; j + countOfOne <= n; j++)
                {
                    dp[i, j] = Math.Max(dp[i, j], 1 + dp[i + countOfZero, j + countOfOne]);//compare dp place, and select 0,1
                    //check all combination, by str, will check str can add or not one by one
                }
            }
        }

        return dp[0, 0];
    }
}