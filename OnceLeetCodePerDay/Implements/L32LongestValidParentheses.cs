using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L32LongestValidParentheses
{
    public int LongestValidParentheses(string s)
    {
        var result = 0;
        var indexStack = new Stack<int>();
        indexStack.Push(-1);
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                indexStack.Push(i);
            }
            else
            {
                if(indexStack.Count > 0)
                {
                    indexStack.Pop();
                }

                if(indexStack.Count == 0)
                {
                    indexStack.Push(i);
                }

                result = Math.Max(result, i - indexStack.Peek());
            }
        }

        return result;
    }
}