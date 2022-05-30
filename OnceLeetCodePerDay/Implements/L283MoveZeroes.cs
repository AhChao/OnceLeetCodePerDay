namespace OnceLeetCodePerDay.Implements;

public class L283MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        var slow = 0;
        for(var quick = 0; quick < nums.Length; quick++)
        {
            if(nums[quick] != 0)
            {
                (nums[slow], nums[quick]) = (nums[quick], nums[slow]);
                slow++;
            }
        }
    }
}