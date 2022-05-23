namespace OnceLeetCodePerDay.Implements;

public class L509FibonacciNumber
{
    public int Fib(int n)
    {
        int fib_1 = 1;
        int fib_2 = 0;
        if(n == 1 || n == 0)
        {
            return n;
        }

        for(var i = 2; i <= n; i++)
        {
            int dp = fib_1 + fib_2;
            fib_2 = fib_1;
            fib_1 = dp;
        }

        return fib_1;
    }
}