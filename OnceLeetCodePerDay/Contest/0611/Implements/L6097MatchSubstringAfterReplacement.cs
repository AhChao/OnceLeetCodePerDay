using System.Collections.Generic;

namespace OnceLeetCodePerDay.Contest._0611.Implements;

public class L6097MatchSubstringAfterReplacement
{
    public bool MatchReplacement(string s, string sub, char[][] mappings)
    {
        var mapping = false;
        var listOfPossibleOfFirstChar = new List<char>() {sub[0]};
        var convertedMapping = new Dictionary<char, HashSet<char>>();
        for(var i = 0; i < mappings.Length; i++)
        {
            convertedMapping.TryAdd(mappings[i][0], new());
            convertedMapping[mappings[i][0]].Add(mappings[i][1]);
            if(mappings[i][0] == sub[0])
            {
                listOfPossibleOfFirstChar.Add(mappings[i][1]);
            }
        }

        for(var i = 0; i < s.Length; i++)
        {
            if(listOfPossibleOfFirstChar.Contains(s[i]))
            {
                for(var j = 0; j < sub.Length; j++)
                {
                    if(i + j >= s.Length)
                    {
                        break;
                    }

                    if(!(sub[j] == s[i + j] || (convertedMapping.ContainsKey(sub[j]) &&
                                                convertedMapping[sub[j]].Contains(s[i + j]))))
                    {
                        break;
                    }

                    if(j == sub.Length - 1)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}