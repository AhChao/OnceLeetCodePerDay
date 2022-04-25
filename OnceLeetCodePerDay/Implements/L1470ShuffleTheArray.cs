namespace OnceLeetCodePerDay.Implements;

public class L1470ShuffleTheArray
{
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[nums.Length];
        for(var i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[n + i];
        }

        return result;
    }
}