namespace OnceLeetCodePerDay.Implements;

public class L2220MinimumBitFlipsToConvertNumber
{
    public int MinBitFlips(int start, int goal)
    {
        var result = 0;
        while(start > 0 || goal > 0)
        {
            var bit1 = start & 1;
            var bit2 = goal & 1;
            result += bit1 ^ bit2;
            start >>= 1;
            goal >>= 1;
        }

        return result;
    }
}