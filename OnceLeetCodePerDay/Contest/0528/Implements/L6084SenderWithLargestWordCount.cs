using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Contest._0528.Implements;

public class L6084SenderWithLargestWordCount
{
    public string LargestWordCount(string[] messages, string[] senders)
    {
        var dictionary = new Dictionary<string, int>();
        for(var i = 0; i < senders.Length; i++)
        {
            var count = messages[i].Split(' ').Length;
            if(dictionary.ContainsKey(senders[i]))
            {
                dictionary[senders[i]] += count;
            }
            else
            {
                dictionary.Add(senders[i], count);
            }
        }

        return dictionary.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key, StringComparer.Ordinal).First()
                         .Key;
    }
}