using System;

namespace OnceLeetCodePerDay.Implements;

public class L29DivideTwoIntegers
{
    public int Divide(int dividend, int divisor)
    {
        var f = (decimal)dividend;
        var f2 = (decimal)divisor;
        var result = f / f2 > 0 ? Math.Floor(f / f2) : Math.Ceiling(f / f2);
        return result > int.MaxValue ? int.MaxValue : result < int.MinValue ? int.MinValue : (int)result;
    }
}