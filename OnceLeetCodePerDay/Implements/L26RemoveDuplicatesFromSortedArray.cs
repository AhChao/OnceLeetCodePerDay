namespace OnceLeetCodePerDay.Implements;

public class L26RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var slow = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[slow] != nums[i])
            {
                slow++;
                nums[slow] = nums[i];
            }
        }

        return slow + 1;
    }
}