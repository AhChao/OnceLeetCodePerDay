using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1091ShortestPathInBinaryMatrix
{
    private (int, int)[] _directions = new[] {(-1, -1), (-1, 0), (-1, 1), (1, -1), (1, 0), (1, 1), (0, -1), (0, 1)};

    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        if(grid[0][0] == 1) return -1;

        var matrixSize = grid.Length - 1;
        var visited = new bool[grid.Length][];
        for(var i = 0; i < visited.Length; i++)
        {
            visited[i] = new bool[grid.Length];
        }

        if(grid[matrixSize][matrixSize] == 1) return -1;

        if(matrixSize == 0) return 1;
        var traverseQueue = new Queue<(int, int)>();
        traverseQueue.Enqueue((0, 1));
        traverseQueue.Enqueue((1, 0));
        traverseQueue.Enqueue((1, 1));
        var step = 1;
        while(traverseQueue.Count != 0)
        {
            step++;
            var initSize = traverseQueue.Count;
            for(var i = 0; i < initSize; i++)
            {
                var pos = traverseQueue.Dequeue();
                var x = pos.Item1;
                var y = pos.Item2;
                if(x < 0 || y < 0 || x > matrixSize || y > matrixSize || grid[x][y] == 1) continue;
                if(!visited[x][y])
                {
                    if(x == y && x == matrixSize) return step;
                    visited[x][y] = true;
                    foreach(var dir in _directions)
                    {
                        traverseQueue.Enqueue((x + dir.Item1, y + dir.Item2));
                    }
                }
            }
        }

        return -1;
    }
}