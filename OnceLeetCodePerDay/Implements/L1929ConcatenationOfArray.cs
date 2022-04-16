namespace OnceLeetCodePerDay.Implements;

public class L1929ConcatenationOfArray
{
    public int[] GetConcatenation(int[] nums)
    {
        var result = new int[nums.Length * 2];
        for(var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }

        return result;
    }
}