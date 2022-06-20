namespace OnceLeetCodePerDay.Implements;

public class L1323Maximum69Number
{
    public int Maximum69Number(int num)
    {
        var numInString = num.ToString();
        var i = 0;
        var result = "";
        for(; i < numInString.Length; i++)
        {
            if(numInString[i] == '6')
            {
                result += '9';
                break;
            }

            result += numInString[i];
        }

        if(i != numInString.Length)
        {
            result += numInString.Substring(i + 1, numInString.Length - i - 1);
        }

        return int.Parse(result);
    }
}