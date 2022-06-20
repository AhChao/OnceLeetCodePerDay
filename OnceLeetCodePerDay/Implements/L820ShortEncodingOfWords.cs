using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L820ShortEncodingOfWords
{
    public int MinimumLengthEncoding(string[] words)
    {
        var list = words.Distinct().OrderBy(x => x.Length).ToList();
        var alreadySubString = new bool[list.Count];
        for(var i = list.Count - 1; i > 0; i--)
        {
            for(var j = 0; j < i; j++)
            {
                if(alreadySubString[j])
                {
                    continue;
                }

                if(list[i].Substring(list[i].Length - list[j].Length, list[j].Length) == list[j])
                {
                    alreadySubString[j] = true;
                }
            }
        }

        return list.Where((x, index) => !alreadySubString[index]).Sum(x => x.Length + 1);
    }
}