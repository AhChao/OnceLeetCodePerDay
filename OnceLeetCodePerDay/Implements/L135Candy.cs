using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L135Candy
{
    public int Candy(int[] r)
    {
        var len = r.Length;
        var candy = new int[len];
        Array.Fill(candy, 1);
        for(var i = 1; i < len; i++)
        {
            if(r[i] > r[i - 1])
            {
                candy[i] = candy[i - 1] + 1;
            }
        }

        for(int i = len - 2; i >= 0; i--)
        {
            if(r[i] > r[i + 1])
            {
                candy[i] = Math.Max(candy[i], candy[i + 1] + 1);
            }
        }

        return candy.Sum();
    }
}