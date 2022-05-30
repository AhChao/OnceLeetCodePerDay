using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1832CheckIfTheSentenceIsPangram
{
    public bool CheckIfPangram(string sentence)
    {
        if(sentence.Length < 26)
        {
            return false;
        }

        var hashSet = new HashSet<char>();
        for(var i = 0; i < sentence.Length; i++)
        {
            hashSet.Add(sentence[i]);
            if(hashSet.Count == 26)
            {
                return true;
            }
        }

        return false;
    }
}