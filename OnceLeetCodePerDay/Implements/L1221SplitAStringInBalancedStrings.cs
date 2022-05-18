namespace OnceLeetCodePerDay.Implements;

public class L1221SplitAStringInBalancedStrings
{
    public int BalancedStringSplit(string s)
    {
        var result = 0;
        int lCount = 0;
        var rCount = 0;
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == 'L')
            {
                lCount++;
            }
            else
            {
                rCount++;
            }

            if((lCount == rCount))
            {
                lCount = 0;
                rCount = 0;
                result++;
            }
        }

        return result;
    }
}