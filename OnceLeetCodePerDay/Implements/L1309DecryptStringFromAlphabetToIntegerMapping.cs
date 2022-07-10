using System;

namespace OnceLeetCodePerDay.Implements;

public class L1309DecryptStringFromAlphabetToIntegerMapping
{
    public string FreqAlphabets(string s)
    {
        var checkingSeg = false;
        var temp = "";
        var result = "";
        for(var i = s.Length - 1; i >= 0; i--)
        {
            if(checkingSeg)
            {
                temp = s[i - 1].ToString() + s[i] + "";
                result = (char)('a' + (Convert.ToInt32(temp) - 1)) + result;
                i--;
                checkingSeg = false;
            }
            else
            {
                if(s[i] == '#')
                {
                    checkingSeg = true;
                }
                else
                {
                    var singleChar = 'a' + (s[i] - '0') - 1;
                    result = Convert.ToChar(singleChar) + result;
                }
            }
        }

        return result;
    }
}