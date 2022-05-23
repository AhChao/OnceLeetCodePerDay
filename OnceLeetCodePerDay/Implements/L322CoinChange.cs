using System;

namespace OnceLeetCodePerDay.Implements;

public class L322CoinChange
{
    private int[] _memo;
    private int[] _coins;

    public int CoinChange(int[] coins, int amount)
    {
        _memo = new int[amount + 1];
        Array.Fill(_memo, -999);
        _coins = coins;
        return DP(amount);
    }

    private int DP(int amount)
    {
        if(amount == 0)
        {
            return 0;
        }

        if(amount < 0)
        {
            return -1;
        }

        if(_memo[amount] != -999)
        {
            return _memo[amount];
        }

        int result = int.MaxValue;
        for(var i = 0; i < _coins.Length; i++)
        {
            var diff = amount - _coins[i];
            var subProblem = DP(diff);
            if(subProblem == -1)
            {
                continue;
            }

            result = Math.Min(result, 1 + subProblem);
        }

        _memo[amount] = result == int.MaxValue ? -1 : result;
        return _memo[amount];
    }
}