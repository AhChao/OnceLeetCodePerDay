namespace OnceLeetCodePerDay.Implements;

public class L905SortArrayByParity
{
    public int[] SortArrayByParity(int[] nums)
    {
        var evenCount = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] % 2 == 0)
            {
                if(evenCount < i)
                {
                    (nums[i], nums[evenCount]) = (nums[evenCount], nums[i]);
                }

                evenCount++;
            }
            else
            {
                (nums[i], nums[evenCount]) = (nums[evenCount], nums[i]);
            }
        }

        return nums;
    }
}