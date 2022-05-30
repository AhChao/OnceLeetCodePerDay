using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1816TruncateSentence
{
    public string TruncateSentence(string s, int k)
    {
        return string.Join(' ', s.Split(" ").Take(k));
    }
}