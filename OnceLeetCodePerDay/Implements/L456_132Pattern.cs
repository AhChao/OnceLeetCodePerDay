using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L456_132Pattern
{
    public bool Find132pattern(int[] nums)
    {
        var stack = new Stack<int>();
        var middleValue = int.MinValue;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(middleValue > nums[i])
            {
                return true;
            }

            while(stack.Count > 0 && nums[i] > stack.Peek())
            {
                middleValue = Math.Max(middleValue, stack.Pop());
            }

            stack.Push(nums[i]);
        }

        return false;
    }
}