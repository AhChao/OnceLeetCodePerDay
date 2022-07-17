namespace OnceLeetCodePerDay.Implements;

public class L97InterleavingString
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        var s1Length = s1.Length;
        var s2Length = s2.Length;
        if(s1Length + s2Length != s3.Length)
        {
            return false;
        }

        var dp = new bool[s1Length + 1, s2Length + 1];
        dp[s1Length, s2Length] = true;

        for(var i = s1Length; i >= 0; i--)
        {
            for(var j = s2Length; j >= 0; j--)
            {
                if((i < s1Length && s1[i] == s3[i + j] && dp[i + 1, j]) ||
                   (j < s2Length && s2[j] == s3[i + j] && dp[i, j + 1]))
                {
                    dp[i, j] = true;
                }
            }
        }

        return dp[0, 0];
    }
}