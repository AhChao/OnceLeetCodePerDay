namespace OnceLeetCodePerDay.Implements;

public class L2176CountEqualAndDivisiblePairsInAnArray
{
    public int CountPairs(int[] nums, int k)
    {
        var result = 0;
        for(var j = 0; j < nums.Length; j++)
        {
            for(var i = 0; i < j; i++)
            {
                if(nums[i] == nums[j] && i * j % k == 0)
                {
                    result++;
                }
            }
        }

        return result;
    }
}