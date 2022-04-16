namespace OnceLeetCodePerDay.Implements;

public class L1920BuildArrayFromPermutation
{
    public int[] BuildArray(int[] nums)
    {
        var i = 0;
        var result = new int[nums.Length];
        while(i < nums.Length)
        {
            result[i] = nums[nums[i]];
            i++;
        }

        return result;
    }
}