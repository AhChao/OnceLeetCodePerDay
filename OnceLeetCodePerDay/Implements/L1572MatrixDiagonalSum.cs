using System;

namespace OnceLeetCodePerDay.Implements;

public class L1572MatrixDiagonalSum
{
    public int DiagonalSum(int[][] mat)
    {
        var sum = 0;
        var leftUpperPoint = (0, 0);
        var rightUpperPoint = (0, mat.Length - 1);
        for(var i = 0; i < mat.Length; i++)
        {
            for(var j = 0; j < mat[i].Length; j++)
            {
                var deltaXWithLeftOne = i - leftUpperPoint.Item1;
                var deltaYWithLeftOne = j - leftUpperPoint.Item2;

                var deltaXWithRightOne = i - rightUpperPoint.Item1;
                var deltaYWithRightOne = j - rightUpperPoint.Item2;
                if((deltaXWithLeftOne == 0 && deltaYWithLeftOne == 0) ||
                   (deltaYWithLeftOne != 0 && Math.Abs(deltaXWithLeftOne / (decimal)deltaYWithLeftOne) == 1) ||
                   (deltaXWithRightOne == 0 && deltaYWithRightOne == 0) ||
                   (deltaYWithRightOne != 0 && Math.Abs(deltaXWithRightOne / (decimal)deltaYWithRightOne) == 1))
                {
                    sum += mat[i][j];
                }
            }
        }

        return sum;
    }
}