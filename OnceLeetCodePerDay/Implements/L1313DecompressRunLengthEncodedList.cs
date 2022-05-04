using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1313DecompressRunLengthEncodedList
{
    public int[] DecompressRLElist(int[] nums)
    {
        var times = 0;
        var result = new List<int>();
        for(var i = 0; i < nums.Length; i++)
        {
            if(i % 2 == 0)
            {
                times = nums[i];
            }
            else
            {
                while(times > 0)
                {
                    times--;
                    result.Add(nums[i]);
                }
            }
        }

        return result.ToArray();
    }
}