namespace OnceLeetCodePerDay.Implements;
//H a b = C a+b-1 a-1
public class L1641CountSortedVowelStrings
{
    public int CountVowelStrings(int i)
    {
        return FactorialWithCount(5 + i - 1) / FactorialWithCount(4);
    }

    private int FactorialWithCount(int target)
    {
        var result = 1;
        for(var i = 0; i < 4; i++)
        {
            result *= (target - i);
        }

        return result;
    }
}