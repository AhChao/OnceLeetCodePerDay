using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1631PathWithMinimumEffort
{
    public int MinimumEffortPath(int[][] heights)
    {
        var minDistanceToPoints = new Dictionary<(int, int), int>();
        for(var i = 0; i < heights.Length; i++)
        {
            for(var j = 0; j < heights[i].Length; j++)
            {
                minDistanceToPoints.Add((i, j), int.MaxValue);
            }
        }

        var processingPoints = new PriorityQueue<L1631ProcessingNodeInfo, int>();
        processingPoints.Enqueue(new L1631ProcessingNodeInfo
                                 {
                                     ProcessingNode = (0, 0),
                                     ToCurNodeEffort = 0
                                 }, 0);
        var dirs = new List<(int, int)>()
                   {(0, 1), (-1, 0), (1, 0), (0, -1)};
        while(processingPoints.Count > 0)
        {
            var point = processingPoints.Dequeue();
            var x = point.ProcessingNode.Item1;
            var y = point.ProcessingNode.Item2;
            if(x == heights.Length - 1 && y == heights[0].Length - 1)
            {
                return point.ToCurNodeEffort;
            }

            if(minDistanceToPoints[(x, y)] > point.ToCurNodeEffort)
            {
                minDistanceToPoints[(x, y)] = point.ToCurNodeEffort;

                foreach(var dir in dirs)
                {
                    var newX = x + dir.Item1;
                    var newY = y + dir.Item2;

                    if(newX < 0 || newY < 0 || newX > heights.Length - 1 || newY > heights[0].Length - 1)
                    {
                        continue;
                    }

                    var newEffort = Math.Max(minDistanceToPoints[(x, y)],
                                             Math.Abs(heights[x][y] - heights[newX][newY]));

                    processingPoints.Enqueue(new L1631ProcessingNodeInfo
                                             {
                                                 ProcessingNode = (newX, newY),
                                                 ToCurNodeEffort = newEffort
                                             }, newEffort);
                }
            }
        }

        return -1;
    }

    public class L1631ProcessingNodeInfo
    {
        public (int, int) ProcessingNode { get; set; }
        public int ToCurNodeEffort { get; set; }
    }
}