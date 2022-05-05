using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1528ShuffleString
{
    public string RestoreString(string s, int[] indices)
    {
        return string.Join("", indices.Select((x, index) => (x, s[index]))
                                      .OrderBy(p => p.x)
                                      .Select(y => y.Item2));
    }
}