namespace OnceLeetCodePerDay.Implements;

public class L1021RemoveOutermostParentheses
{
    public string RemoveOuterParentheses(string s)
    {
        var result = "";
        var leftCount = 0;
        var checking = false;
        for(var i = 0; i < s.Length; i++)
        {
            if(!checking)
            {
                checking = true;
                continue;
            }

            if(s[i] == '(')
            {
                leftCount++;
                result += s[i];
            }
            else
            {
                if(leftCount == 0)
                {
                    checking = false;
                    continue;
                }
                else
                {
                    leftCount--;
                    result += s[i];
                }
            }
        }

        return result;
    }
}