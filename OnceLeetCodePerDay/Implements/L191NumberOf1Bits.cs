namespace OnceLeetCodePerDay.Implements;

public class L191NumberOf1Bits
{
    public int HammingWeight(uint n)
    {
        var result = 0;
        while(n != 0)
        {
            n = n & (n - 1);//This will remove last 1 in binary calculation
            result++;
        }

        return result;
    }
}