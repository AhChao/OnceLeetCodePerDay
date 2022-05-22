using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L647PalindromicSubstrings
{
    private Dictionary<string, bool> _palindromicDict;

    public int CountSubstrings(string s)
    {
        var result = 0;
        _palindromicDict = new Dictionary<string, bool>();
        var str = "";
        for(var i = 0; i < s.Length; i++)
        {
            str = s[i].ToString();
            for(var j = i; j < s.Length; j++)
            {
                if(j != i)
                {
                    str += s[j];
                }

                if(IsPalindromic(str))
                {
                    result++;
                }
            }
        }

        return result;
    }

    private bool IsPalindromic(string track)
    {
        if(!_palindromicDict.ContainsKey(track))
        {
            var left = 0;
            var right = track.Length - 1;
            var isPalindromic = true;
            while(left < right)
            {
                if(track[left] != track[right])
                {
                    isPalindromic = false;
                    break;
                }

                left++;
                right--;
            }

            _palindromicDict.Add(track, isPalindromic);
        }

        return _palindromicDict[track];
    }
}