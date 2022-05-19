using System;

namespace OnceLeetCodePerDay.Implements;

public class L329LongestIncreasingPathInAMatrix
{
    private int _result;
    private int[][] _matrix;
    private int[,] _lenCache;
    private (int, int)[] _dirs = new[] {(0, 1), (1, 0), (-1, 0), (0, -1)};

    public int LongestIncreasingPath(int[][] matrix)
    {
        _result = 0;
        _matrix = matrix;
        _lenCache = new int[matrix.Length, matrix[0].Length];
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                Traverse(i, j, 0);
            }
        }

        return _result;
    }

    private void Traverse(int i, int j, int len)
    {
        len++;
        if(_lenCache[i, j] > len)
        {
            return;
        }
        else
        {
            _lenCache[i, j] = len;
            _result = Math.Max(len, _result);
        }

        foreach(var dir in _dirs)
        {
            var newCoordinate = (i + dir.Item1, j + dir.Item2);
            if(IsValidPath(newCoordinate, _matrix[i][j]))
            {
                Traverse(newCoordinate.Item1, newCoordinate.Item2, len);
            }
        }
    }

    private bool IsValidPath((int, int) coordinate, int value)
    {
        return coordinate.Item1 >= 0 && coordinate.Item2 >= 0 && coordinate.Item1 < _matrix.Length &&
               coordinate.Item2 < _matrix[0].Length &&
               _matrix[coordinate.Item1][coordinate.Item2] > value;
    }
}