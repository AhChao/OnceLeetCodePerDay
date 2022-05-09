using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L17LetterCombinationsOfAPhoneNumber
{
    private Dictionary<string, string[]> _keyMap = new Dictionary<string, string[]>()
                                                   {
                                                       {"2", new[] {"a", "b", "c"}},
                                                       {"3", new[] {"d", "e", "f"}},
                                                       {"4", new[] {"g", "h", "i"}},
                                                       {"5", new[] {"j", "k", "l"}},
                                                       {"6", new[] {"m", "n", "o"}},
                                                       {"7", new[] {"p", "q", "r", "s"}},
                                                       {"8", new[] {"t", "u", "v"}},
                                                       {"9", new[] {"w", "x", "y", "z"}},
                                                   };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        foreach(var strings in digits.ToArray().Select(x => _keyMap[x.ToString()]))
        {
            var temp = new List<string>();
            if(result.Count == 0)
            {
                foreach(var s in strings)
                {
                    result.Add(s);
                }
            }
            else
            {
                foreach(var s in strings)
                {
                    foreach(var s1 in result)
                    {
                        temp.Add(s1 + s);
                    }
                }

                result = temp.ToList();
            }
        }

        return result;
    }
}