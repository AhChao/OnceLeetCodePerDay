using System;

namespace OnceLeetCodePerDay.Implements;

public class L1844ReplaceAllDigitsWithCharacters
{
    public string ReplaceDigits(string s)
    {
        var result = "";
        for(var i = 0; i < s.Length; i += 2)
        {
            result += s[i];
            if(i + 1 < s.Length)
            {
                result += Convert.ToChar(s[i] + int.Parse(s[i + 1].ToString()));
            }
        }

        return result;
    }
}