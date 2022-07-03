namespace OnceLeetCodePerDay.Implements;

public class L376WiggleSubsequence
{
    public int WiggleMaxLength(int[] nums)
    {
        if(nums.Length < 2)
        {
            return nums.Length;
        }

        var lastDiff = 0;
        var lastCountIn = lastDiff;
        var switchTimes = 1;

        for(var i = 1; i < nums.Length; i++)
        {
            var diff = nums[i] - nums[i - 1];
            if(diff == 0)
            {
                continue;
            }

            if((lastDiff > 0 && diff < 0) || (lastDiff < 0 && diff > 0) || lastDiff == 0)
            {
                switchTimes++;
            }

            lastDiff = diff;
        }

        return switchTimes;
    }
}