using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L118PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();
        result.Add(new List<int>() {1});
        for(int i = 1; i < numRows; i++)
        {
            var row = new List<int>();
            var mid = numRows / 2;
            for(int j = 0; j <= i; j++)
            {
                if(j > mid)
                {
                    row.Add(row[i - j]);
                }
                else
                {
                    var upperLeft = j > 0 ? result[i - 1][j - 1] : 0;
                    var upperRight = j < i ? result[i - 1][j] : 0;
                    row.Add(upperLeft + upperRight);
                }
            }

            result.Add(row.ToList());
        }

        return result;
    }
}