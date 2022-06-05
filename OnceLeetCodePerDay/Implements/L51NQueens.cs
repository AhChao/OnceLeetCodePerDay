using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L51NQueens
{
    private int _max;
    private List<IList<string>> _formatteResult;

    public IList<IList<string>> SolveNQueens(int n)
    {
        _formatteResult = new List<IList<string>>();
        _max = n;

        BackTracking(new List<(int, int)>(), 0);
        return _formatteResult;
    }

    private void BackTracking(List<(int, int)> queensPlace, int startingPlace)
    {
        if(queensPlace.Count == _max)
        {
            GenerateResultList(queensPlace);
        }

        for(var i = startingPlace; i < _max; i++)
        {
            for(var j = 0; j < _max; j++)
            {
                var isValidPlace =
                    queensPlace.Count(x => x.Item1 == i || x.Item2 == j ||
                                           Math.Abs(x.Item1 - i) == Math.Abs(x.Item2 - j)) == 0;
                if(!isValidPlace)
                {
                    continue;
                }

                queensPlace.Add((i, j));
                BackTracking(queensPlace, i + 1);
                queensPlace.RemoveAt(queensPlace.Count - 1);
            }
        }
    }

    private void GenerateResultList(List<(int, int)> queensPlace)
    {
        var queensPlaceIndex = 0;
        var list = new List<string>();
        for(var i = 0; i < _max; i++)
        {
            var s = "";
            for(var j = 0; j < _max; j++)
            {
                if(queensPlaceIndex >= queensPlace.Count)
                {
                    s += '.';
                    continue;
                }

                var queenPlace = queensPlace[queensPlaceIndex];
                if(queenPlace.Item1 == i && queenPlace.Item2 == j)
                {
                    s += 'Q';
                    queensPlaceIndex++;
                }
                else
                {
                    s += '.';
                }
            }

            list.Add(s);
        }

        _formatteResult.Add(list);
    }
}