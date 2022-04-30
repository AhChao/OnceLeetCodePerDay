using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Contest._0430.Implement;

public class L6052MinimumAverageDifference
{
    public int MinimumAverageDifference(int[] nums)
    {
        if(nums.Length == 1) return 0;
        long total = 0;
        foreach(var n in nums) total += n;
        var result = 0;
        long minValue = int.MaxValue;
        var dict = new Dictionary<int, long>();
        dict.Add(0, nums[0]);
        total -= nums[0];
        minValue = Math.Abs(dict[0] - (int)Math.Floor((decimal)total / (nums.Length - 1)));
        for(var i = 1; i < nums.Length; i++)
        {
            var dictValue = dict[i - 1] + nums[i];
            dict[i] = dictValue;
            total -= nums[i];
            var value1 = (int)Math.Floor((decimal)dictValue / (i + 1));
            var value2 = (int)Math.Floor((decimal)(nums.Length - (i + 1) != 0 ? total / (nums.Length - (i + 1)) : 0));
            long absValue = Math.Abs(value1 - value2);
            if(absValue < minValue)
            {
                minValue = absValue;
                result = i;
            }
        }

        return result;
    }
}