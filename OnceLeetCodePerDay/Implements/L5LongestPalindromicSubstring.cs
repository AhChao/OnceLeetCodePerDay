namespace OnceLeetCodePerDay.Implements;

public class L5LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        var temp = "";
        var result = "";
        for(var i = 0; i < s.Length; i++) //take s[i] as center
        {
            temp = FoundLongestPalindromeFromCenter(s, i, i);
            result = result.Length > temp.Length ? result : temp;
            if(i + 1 < s.Length && s[i] == s[i + 1])
            {
                temp = FoundLongestPalindromeFromCenter(s, i, i + 1);
                result = result.Length > temp.Length ? result : temp;
            }
        }

        return result;
    }

    private static string FoundLongestPalindromeFromCenter(string s, int left, int right)
    {
        string temp = left != right ? (s[left] + "" + s[right]) : s[left].ToString();
        left--;
        right++;
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            temp = s[left] + temp + s[right];
            left--;
            right++;
        }

        return temp;
    }
}