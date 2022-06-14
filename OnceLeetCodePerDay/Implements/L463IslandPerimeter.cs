namespace OnceLeetCodePerDay.Implements;

public class L463IslandPerimeter
{
    public int IslandPerimeter(int[][] grid)
    {
        var sum = 0;
        for(var i = 0; i < grid.Length; i++)
        {
            for(var j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 1)
                {
                    sum += 4 - Get1CountAdj(grid, i, j);
                }
            }
        }

        return sum;
    }

    private int Get1CountAdj(int[][] grid, int i, int j)
    {
        var total = 0;
        if(i > 0 && grid[i - 1][j] == 1)
        {
            total++;
        }

        if(i + 1 < grid.Length && grid[i + 1][j] == 1)
        {
            total++;
        }

        if(j > 0 && grid[i][j - 1] == 1)
        {
            total++;
        }

        if(j + 1 < grid[i].Length && grid[i][j + 1] == 1)
        {
            total++;
        }

        return total;
    }
}