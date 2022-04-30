using System;

namespace OnceLeetCodePerDay.Contest._0430.Implement;

public class L6052MinimumAverageDifference
{
    public int MinimumAverageDifference(int[] nums)
    {
        if(nums.Length == 1) return 0;
        long part1 = 0;
        long part2 = 0;
        foreach(var n in nums) part2 += n;
        var result = 0;
        long minValue = int.MaxValue;
        part1 = nums[0];
        part2 -= nums[0];
        minValue = Math.Abs(part1 - (int)Math.Floor((decimal)part2 / (nums.Length - 1)));
        for(var i = 1; i < nums.Length; i++)
        {
            var dictValue = part1 + nums[i];
            part1 = dictValue;
            part2 -= nums[i];
            var value1 = (int)Math.Floor((decimal)dictValue / (i + 1));
            var value2 = (int)Math.Floor((decimal)(nums.Length - (i + 1) != 0 ? part2 / (nums.Length - (i + 1)) : 0));
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