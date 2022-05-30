using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L349IntersectionOfTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var hashSet = new HashSet<int>();
        for(var i = 0; i < nums1.Length; i++)
        {
            for(var j = 0; j < nums2.Length; j++)
            {
                if(nums1[i] == nums2[j])
                {
                    hashSet.Add(nums1[i]);
                }
            }
        }

        return hashSet.ToArray();
        //return nums1.Distinct().Intersect(nums2.Distinct()).ToArray();
    }
}