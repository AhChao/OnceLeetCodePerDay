namespace OnceLeetCodePerDay.Implements;

public class NumMatrix
{
    private int[][] _sumOfFieldFromOriginMartrix;

    public NumMatrix(int[][] matrix)
    {
        _sumOfFieldFromOriginMartrix = new int[matrix.Length + 1][];
        _sumOfFieldFromOriginMartrix[0] = new int[matrix[0].Length + 1];
        for(var i = 1; i <= matrix.Length; i++)
        {
            _sumOfFieldFromOriginMartrix[i] = new int[matrix[0].Length + 1];
            for(var j = 1; j <= matrix[0].Length; j++)
            {
                _sumOfFieldFromOriginMartrix[i][j] = matrix[i - 1][j - 1] + _sumOfFieldFromOriginMartrix[i - 1][j] +
                                                     _sumOfFieldFromOriginMartrix[i][j - 1] -
                                                     _sumOfFieldFromOriginMartrix[i - 1][j - 1];
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        return _sumOfFieldFromOriginMartrix[row2 + 1][col2 + 1] + _sumOfFieldFromOriginMartrix[row1][col1] -
               _sumOfFieldFromOriginMartrix[row1][col2 + 1] - _sumOfFieldFromOriginMartrix[row2 + 1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */