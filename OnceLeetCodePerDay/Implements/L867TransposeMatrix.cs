namespace OnceLeetCodePerDay.Implements;

public class L867TransposeMatrix
{
    public int[][] Transpose(int[][] matrix)
    {
        var result = new int[matrix[0].Length][];
        for(var index = 0; index < result.Length; index++)
        {
            result[index] = new int[matrix.Length];
        }

        for(int i = 0; i < matrix.Length; i++)
        {
            for(var j = 0; j < matrix[0].Length; j++)
            {
                result[j][i] = matrix[i][j];
            }
        }

        return result;
    }
}