using System;

namespace OnceLeetCodePerDay.Implements;

public class L1534CountGoodTriplets
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        var result = 0;
        for(var i = 0; i < arr.Length; i++)
        {
            for(var j = 0; j < i; j++)
            {
                if(Math.Abs(arr[j] - arr[i]) > b)
                {
                    continue;
                }

                for(int k = 0; k < j; k++)
                {
                    if(Math.Abs(arr[k] - arr[j]) <= a &&
                       Math.Abs(arr[k] - arr[i]) <= c)
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }
}