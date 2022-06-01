using System;

namespace OnceLeetCodePerDay.Implements;

public class L29DivideTwoIntegers
{
    public int Divide(int dividend, int divisor)
    {
        if(divisor == dividend)
            return 1;
        if(dividend == int.MinValue && divisor == -1)
            return int.MaxValue;
        int times;
        var isResultPositive = (dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0);
        long longDividend = Math.Abs((long)dividend);
        long longDivisor = Math.Abs((long)divisor);
        if(longDivisor > longDividend)
            return 0;
        times = DoubleAndCheck(longDividend, longDivisor);

        return isResultPositive ? times : -times;
    }

    private int DoubleAndCheck(long longDividend, long longDivisor)
    {
        if(longDividend < longDivisor)
        {
            return 0;
        }

        if(longDividend == longDivisor)
        {
            return 1;
        }

        long lastResult = 0;
        int lastTimes = 0;
        var clum = longDivisor;
        var times = 1;
        while(clum < longDividend)
        {
            lastResult = clum;
            lastTimes = times;
            times += times;
            clum += clum;
        }

        return lastTimes + DoubleAndCheck(longDividend - lastResult, longDivisor);
    }
}