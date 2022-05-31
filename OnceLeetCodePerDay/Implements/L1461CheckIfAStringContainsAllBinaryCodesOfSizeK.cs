using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1461CheckIfAStringContainsAllBinaryCodesOfSizeK
{
    public bool HasAllCodes(string s, int k)
    {
        var hashSet = new HashSet<string>();
        for(var i = 0; i < s.Length - k + 1; i++)
        {
            hashSet.Add(s.Substring(i, k));
        }

        return hashSet.Count == Math.Pow(2, k);
    }
}