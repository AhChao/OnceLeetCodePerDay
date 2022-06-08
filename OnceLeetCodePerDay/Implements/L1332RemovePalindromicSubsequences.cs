namespace OnceLeetCodePerDay.Implements;

public class L1332RemovePalindromicSubsequences
{
    public int RemovePalindromeSub(string s)
    {
        var right = s.Length / 2;
        var left = s.Length % 2 == 0 ? right - 1 : right;
        while(left >= 0)
        {
            if(s[left] != s[right])
            {
                return 2;
            }

            left--;
            right++;
        }

        return 1;
    }
}