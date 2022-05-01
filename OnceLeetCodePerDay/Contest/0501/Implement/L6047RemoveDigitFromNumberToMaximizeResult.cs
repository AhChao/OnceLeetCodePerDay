namespace OnceLeetCodePerDay.Contest._0501.Implement;

public class L6047RemoveDigitFromNumberToMaximizeResult
{
    public string RemoveDigit(string number, char digit)
    {
        var temp = "";
        var max = "0";
        for(var i = 0; i < number.Length; i++)
        {
            if(number[i] == digit)
            {
                temp = FormResult(number, i);
                if(IsTempBiggerThanMax(max, temp))
                {
                    max = temp;
                }
            }
        }

        return max;
    }

    private bool IsTempBiggerThanMax(string max, string temp)
    {
        for(var i = 0; i < temp.Length; i++)
        {
            if(max[i] < temp[i]) return true;
            if(max[i] > temp[i]) return false;
            if(max[i] == temp[i]) continue;
        }

        return false;
    }

    private static string FormResult(string number, int indexOfDigit)
    {
        var frontString = indexOfDigit == 0 ? "" : number.Substring(0, indexOfDigit);
        var endString = indexOfDigit == number.Length - 1 ? "" : number.Substring(indexOfDigit + 1);
        return frontString + endString;
    }
}