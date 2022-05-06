using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1209RemoveAllAdjacentDuplicatesInStringII
{
    public string RemoveDuplicates(string s, int k)
    {
        var chars = new Stack<char>();
        var charCount = new Stack<int>();
        var streak = 1;
        var needToCheck = false;
        for(var i = 0; i < s.Length; i++)
        {
            if(chars.Count > 0 && s[i] == chars.Peek())
            {
                charCount.Push(charCount.Peek() + 1);
            }
            else
            {
                charCount.Push(1);
            }

            chars.Push(s[i]);
            if(charCount.Peek() == k)
            {
                for(var j = 0; j < k; j++)
                {
                    chars.Pop();
                    charCount.Pop();
                }
            }
        }

        return String.Join("", chars.ToArray().Reverse());
    }
}