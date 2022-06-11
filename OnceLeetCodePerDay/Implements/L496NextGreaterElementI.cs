using System;

namespace OnceLeetCodePerDay.Implements;

public class L496NextGreaterElementI
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];
        for(var i = 0; i < nums1.Length; i++)
        {
            var indexOf = Array.IndexOf(nums2, nums1[i]);
            var temp = -1;
            for(var j = indexOf; j < nums2.Length; j++)
            {
                if(nums2[j] > nums1[i])
                {
                    temp = nums2[j];
                    break;
                }
            }

            result[i] = temp;
        }

        return result;
    }
}