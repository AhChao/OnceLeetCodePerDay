using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L583DeleteOperationForTwoStrings
{
    private Dictionary<(int, int), int> _memo;

    public int MinDistance(string word1, string word2)
    {
        _memo = new Dictionary<(int, int), int>();
        var longestLengthOfTheSameSubArray = LongestLengthOfTheSameSubArray(word1, 0, word2, 0);
        return word1.Length - longestLengthOfTheSameSubArray + word2.Length - longestLengthOfTheSameSubArray;
    }

    private int LongestLengthOfTheSameSubArray(string word1, int word1StartIndex, string word2, int word2StartIndex)
    {
        if(word1StartIndex == word1.Length || word2StartIndex == word2.Length)
        {
            return 0;
        }

        if(_memo.ContainsKey((word1StartIndex, word2StartIndex)))
        {
            return _memo[(word1StartIndex, word2StartIndex)];
        }

        if(word1[word1StartIndex] == word2[word2StartIndex])
        {
            _memo[(word1StartIndex, word2StartIndex)] =
                1 + LongestLengthOfTheSameSubArray(word1, word1StartIndex + 1, word2, word2StartIndex + 1);
        }
        else
        {
            var condition1 = LongestLengthOfTheSameSubArray(word1, word1StartIndex + 1, word2, word2StartIndex);
            var condition2 = LongestLengthOfTheSameSubArray(word1, word1StartIndex, word2, word2StartIndex + 1);
            _memo[(word1StartIndex, word2StartIndex)] = Math.Max(condition1, condition2);
        }

        return _memo[(word1StartIndex, word2StartIndex)];
    }
}