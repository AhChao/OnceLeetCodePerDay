namespace OnceLeetCodePerDay.Implements;

public class L1614MaximumNestingDepthOfTheParentheses
{
    public int MaxDepth(string s)
    {
        var maxDepth = 0;
        var depth = 0;
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                depth++;
            }

            if(s[i] == ')')
            {
                maxDepth = maxDepth > depth ? maxDepth : depth;
                depth--;
            }
        }

        return maxDepth;
    }
}