using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L2194CellsInARangeOnAnExcelSheet
{
    public IList<string> CellsInRange(string s)
    {
        var result = new List<string>();
        var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        for(int i = (s[0] - 'A'); i <= (s[3] - 'A'); i++)
        {
            for(int j = s[1] - '0'; j <= s[4] - '0'; j++)
            {
                result.Add(new string(alpha[i] + j.ToString()));
            }
        }

        return result;
    }
}