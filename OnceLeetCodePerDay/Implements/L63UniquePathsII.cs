namespace OnceLeetCodePerDay.Implements;

public class L63UniquePathsII
{
    private int[][] _obstacleGrid;
    private int[][] _cache;

    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        _obstacleGrid = obstacleGrid;
        _cache = new int[obstacleGrid.Length][];
        for(var index = 0; index < _cache.Length; index++)
        {
            _cache[index] = new int[obstacleGrid[0].Length];
            for(var i = 0; i < obstacleGrid[0].Length; i++)
            {
                _cache[index][i] = -1;
            }
        }

        _cache[0][0] = obstacleGrid[0][0] == 0 ? 1 : 0;
        return GetValueOfPoint(obstacleGrid.Length - 1, obstacleGrid[0].Length - 1);
    }

    private int GetValueOfPoint(int x, int y)
    {
        if(x < 0 || y < 0 || _obstacleGrid[x][y] == 1)
        {
            return 0;
        }

        if(_cache[x][y] == -1)
        {
            _cache[x][y] = GetValueOfPoint(x - 1, y) + GetValueOfPoint(x, y - 1);
        }

        return _cache[x][y];
    }
}