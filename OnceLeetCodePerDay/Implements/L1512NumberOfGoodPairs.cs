using System.Collections.Generic;

namespace OnceLeetCodePerDay.I;

public class L1512NumberOfGoodPairs
{
    public int NumIdenticalPairs(int[] nums)
    {
        var pairCount = 0;
        var containedNums = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if(!containedNums.ContainsKey(num)) containedNums.Add(num, 1);
            else
            {
                pairCount += containedNums[num];
                containedNums[num]++;
            }
        }

        return pairCount;
    }
}