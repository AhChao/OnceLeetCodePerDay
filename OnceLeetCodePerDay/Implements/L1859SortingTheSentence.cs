using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1859SortingTheSentence
{
    public string SortSentence(string s)
    {
        return string.Join(' ', s.Split(" ").OrderBy(x => x.Last()).Select(x => x.Substring(0, x.Length - 1)));
    }
}