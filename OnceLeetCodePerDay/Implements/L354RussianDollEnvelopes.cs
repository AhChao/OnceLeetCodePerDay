using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L354RussianDollEnvelopes
{
    public int MaxEnvelopes(int[][] envelopes)
    {
        var lisArr = envelopes.OrderBy(x => x[0]).ThenByDescending(x => x[1]).Select(x => x[1]).ToArray();
        var dp = new int[lisArr.Length];
        Array.Fill(dp, 1);
        var list = new List<int>();
        var newHeapNeed = true;
        return LIS(lisArr);
    }

    private int LIS(int[] lisArr)
    {
        var dp = new int[lisArr.Length];
        var piles = 0;
        for(int i = 0; i < lisArr.Length; i++)
        {
            var index = Array.BinarySearch(dp, 0, piles, lisArr[i]);
            if(index < 0)
            {
                index = -(index + 1);
            }

            dp[index] = lisArr[i];
            if(index == piles)
            {
                piles++;
            }
        }

        return piles;
    }
}