using System;

namespace OnceLeetCodePerDay.Implements;

public class L215KthLargestElementInAnArray
{
    //can check another algo named quick selection
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);
        return nums[^k];
    }
}