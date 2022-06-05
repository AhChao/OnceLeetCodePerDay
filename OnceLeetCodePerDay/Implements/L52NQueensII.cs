using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L52NQueensII
{
    private int _result;

    public int TotalNQueens(int n)
    {
        _result = 0;
        BackTracking(new List<(int, int)>(), 0, n);
        return _result;
    }

    private void BackTracking(List<(int, int)> queensPlace, int startingPlace, int n)
    {
        if(queensPlace.Count == n)
        {
            _result += 1;
        }

        for(var i = startingPlace; i < n; i++)
        {
            for(var j = 0; j < n; j++)
            {
                var isValidPlace =
                    queensPlace.Count(x => x.Item1 == i || x.Item2 == j ||
                                           Math.Abs(x.Item1 - i) == Math.Abs(x.Item2 - j)) == 0;
                if(!isValidPlace)
                {
                    continue;
                }

                queensPlace.Add((i, j));
                BackTracking(queensPlace, i + 1, n);
                queensPlace.RemoveAt(queensPlace.Count - 1);
            }
        }
    }
}