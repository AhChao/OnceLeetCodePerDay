using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L318MaximumProductOfWordLengths
{
    public int MaxProduct(string[] words)
    {
        var result = 0;
        var l318Temps = words.Select(x => new L318Temp() {Chars = x.Distinct().ToArray(), Length = x.Length}).ToList();
        for(var i = 0; i < l318Temps.Count; i++)
        {
            for(var j = 0; j < l318Temps.Count; j++)
            {
                if(l318Temps[i].Chars.All(x => l318Temps[j].Chars.All(y => x != y)))
                {
                    result = Math.Max(result, l318Temps[i].Length * l318Temps[j].Length);
                }
            }
        }

        return result;
    }

    public class L318Temp
    {
        public int Length { get; set; }
        public char[] Chars { get; set; }
    }
}