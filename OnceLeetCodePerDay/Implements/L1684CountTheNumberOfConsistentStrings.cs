using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1684CountTheNumberOfConsistentStrings
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var result = 0;
        for(var i = 0; i < words.Length; i++)
        {
            if(words[i].Distinct().All(x => allowed.Contains(x)))
            {
                result++;
            }
        }

        return result;
    }
}