using System;

namespace OnceLeetCodePerDay.Implements;

public class L88MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for(var i = 0; i < nums1.Length; i++)
        {
            if(i >= m)
            {
                nums1[i] = nums2[i - m];
            }
        }

        Array.Sort(nums1);
    }
}