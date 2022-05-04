using System.Collections.Generic;

namespace OnceLeetCodePerDay.Contest._0501.Implement;

public class L6049KDivisibleElementsSubarrays
{
    public int CountDistinct(int[] nums, int k, int p)
    {
        var combinationList = new HashSet<string>();
        for(var i = 0; i < nums.Length; i++)
        {
            var str = "";
            var divCount = 0;
            for(var j = i; j < nums.Length; j++)
            {
                if(nums[j] % p == 0) divCount++;
                if(divCount > k) break;
                str += nums[j] + "_";
                combinationList.Add(str);
            }
        }

        return combinationList.Count;
    }
}