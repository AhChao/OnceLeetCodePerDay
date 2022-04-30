namespace OnceLeetCodePerDay.Contest._0430.Implement;

public class L6051CountPrefixesOfAGivenString
{
    public double CountPrefixes(string[] words, string s)
    {
        var result = 0;
        foreach(var i in words)
        {
            if(i.Length > s.Length) continue;
            result += s.Substring(0, i.Length) == i ? 1 : 0;
        }

        return result;
    }
}