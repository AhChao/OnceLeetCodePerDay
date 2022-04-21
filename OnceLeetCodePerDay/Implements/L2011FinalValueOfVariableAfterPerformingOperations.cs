using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L2011FinalValueOfVariableAfterPerformingOperations
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var x = 0;
        for(var i = 0; i < operations.Length; i++)
        {
            if(operations[i][0] == '-' || operations[i][1] == '-') x--;
            else x++;
        }

        return x;
    }
}