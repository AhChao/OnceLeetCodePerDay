using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L2089FindTargetIndicesAfterSortingArray
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        var result = new List<int>();
        Array.Sort(nums);
        for(var i = 0; i < nums.Length; i++)
        {
            if(nums[i] == target)
            {
                result.Add(i);
            }
        }

        return result;
    }
}