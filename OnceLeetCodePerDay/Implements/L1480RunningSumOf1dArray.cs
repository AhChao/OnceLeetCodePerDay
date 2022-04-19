namespace OnceLeetCodePerDay.Implements;

public class L1480RunningSumOf1dArray
{
    public int[] RunningSum(int[] nums)
    {
        for(var i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}