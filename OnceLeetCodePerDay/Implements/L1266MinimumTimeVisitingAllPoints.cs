using System;

namespace OnceLeetCodePerDay.Implements;

public class L1266MinimumTimeVisitingAllPoints
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        var result = 0;
        for(var i = 1; i < points.Length; i++)
        {
            var lastPoint = points[i - 1];
            var point = points[i];
            result += Math.Max(Math.Abs(lastPoint[0] - point[0]), Math.Abs(lastPoint[1] - point[1]));
        }

        return result;
    }
}