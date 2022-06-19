using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class WordFilter
{
    public Dictionary<string, int> _dictionary { get; set; }

    public WordFilter(string[] words)
    {
        _dictionary = new Dictionary<string, int>();
        for(var index = 0; index < words.Length; index++)
        {
            var word = words[index];
            for(var i = 0; i < word.Length; i++)
            {
                var prefix = word.Substring(0, i + 1);
                for(var j = 0; j < word.Length; j++)
                {
                    var suffix = word.Substring(j, word.Length - j);
                    var key = prefix + "_" + suffix;
                    if(!_dictionary.TryAdd(key, index))
                    {
                        _dictionary[key] = index;
                    }
                }
            }
        }
    }

    public int F(string prefix, string suffix)
    {
        var key = prefix + "_" + suffix;
        return _dictionary.ContainsKey(key) ? _dictionary[key] : -1;
    }
}