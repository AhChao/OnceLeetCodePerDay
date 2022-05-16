namespace OnceLeetCodePerDay.Implements;

public class L136SingleNumber
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach(var t in nums)
        {
            result ^= t;
        }

        return result;
    }
}