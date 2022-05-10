namespace OnceLeetCodePerDay.Implements;

public class L1389CreateTargetArrayInTheGivenOrder
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        var result = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++)
        {
            var indexI = index[i];
            if(indexI < i)
            {
                for(var j = nums.Length - 1; j > indexI; j--)
                {
                    result[j] = result[j - 1];
                }

                result[indexI] = nums[i];
            }
            else
            {
                result[indexI] = nums[i];
            }
        }

        return result;
    }
}