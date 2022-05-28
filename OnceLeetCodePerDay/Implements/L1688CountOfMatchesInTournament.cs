namespace OnceLeetCodePerDay.Implements;

public class L1688CountOfMatchesInTournament
{
    public int NumberOfMatches(int n)
    {
        int result = 0;
        while(n > 0)
        {
            if(n % 2 == 0)
            {
                n /= 2;
                result += n;
            }
            else
            {
                n -= 1;
                n /= 2;
                result += n;
                if(n != 0)
                {
                    n += 1;
                }
            }
        }

        return result;
    }
}