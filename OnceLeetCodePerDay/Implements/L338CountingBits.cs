namespace OnceLeetCodePerDay.Implements;

public class L338CountingBits
{
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];
        for(int i = 0; i < n + 1; i++)
        {
            result[i] = GetOneCounting(i, 0);
        }

        return result;
    }

    private int GetOneCounting(int num, int result)
    {
        if(num == 0) return result;
        return GetOneCounting(num / 2, num % 2 == 0 ? result : result + 1);
    }
}