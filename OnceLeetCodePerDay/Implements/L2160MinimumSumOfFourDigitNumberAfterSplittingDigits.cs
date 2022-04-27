using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L2160MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    public int MinimumSum(int num)
    {
        var numInArr = new int[4];
        for(var i = 0; i < numInArr.Length; i++)
        {
            numInArr[i] = num % 10;
            num /= 10;
        }

        numInArr = numInArr.OrderBy(x => x).ToArray();
        var num1 = (numInArr[0] * 10 + numInArr[2]);
        var num2 = (numInArr[1] * 10 + numInArr[3]);
        return num1 + num2;
    }
}