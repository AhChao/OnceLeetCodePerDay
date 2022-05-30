using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L2103RingsAndRods
{
    public int CountPoints(string rings)
    {
        var dictionary = new Dictionary<int, HashSet<char>>();
        for(var i = 0; i < rings.Length; i += 2)
        {
            if(dictionary.ContainsKey(rings[i + 1]))
            {
                dictionary[rings[i + 1]].Add(rings[i]);
            }
            else
            {
                dictionary.Add(rings[i + 1], new HashSet<char>() {rings[i]});
            }
        }

        return dictionary.Count(x => x.Value.Count == 3);
    }
}