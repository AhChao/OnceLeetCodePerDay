using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1048LongestStringChain
{
    public int LongestStrChain(string[] words)
    {
        var orderedWords = words.OrderBy(x => x.Length).ToList();
        var list = new List<StringWithInt>();
        for(var i = 0; i < orderedWords.Count; i++)
        {
            var mappingCount = list.Where(x => IsPredecessor(x.Tail, orderedWords[i]));
            if(!mappingCount.Any())
            {
                list.Add(new StringWithInt
                         {
                             Tail = orderedWords[i],
                             Length = 1
                         });
            }
            else
            {
                var max = mappingCount.Max(x => x.Length) + 1;
                list.Add(new StringWithInt()
                         {
                             Tail = orderedWords[i],
                             Length = max
                         });
            }
        }

        return list.Max(x => x.Length);
    }

    private bool IsPredecessor(string wordA, string wordB)
    {
        if(Math.Abs(wordA.Length - wordB.Length) != 1)
        {
            return false;
        }

        var count = 0;
        var indexA = 0;
        var indexB = 0;
        while(indexA < wordA.Length && indexB < wordB.Length)
        {
            if(wordA[indexA] == wordB[indexB])
            {
                indexA++;
                indexB++;
            }
            else
            {
                if(count == 1)
                {
                    return false;
                }

                count++;
                indexB++;
            }
        }

        return true;
    }
}

public class StringWithInt
{
    public string Tail { get; set; }
    public int Length { get; set; }
}