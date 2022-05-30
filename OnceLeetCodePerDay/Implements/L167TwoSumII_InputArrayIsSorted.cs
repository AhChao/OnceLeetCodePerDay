using System;

namespace OnceLeetCodePerDay.Implements;

public class L167TwoSumII_InputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while(left < right)
        {
            var twoSum = numbers[left] + numbers[right];
            if(twoSum == target)
            {
                return new[] {left + 1, right + 1};
            }

            if(twoSum < target)
            {
                left++;
            }

            if(twoSum > target)
            {
                right--;
            }
        }

        throw new NotSupportedException();
    }
}