using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L682BaseballGame
{
    public int CalPoints(string[] ops)
    {
        var list = new List<int>();
        for(var i = 0; i < ops.Length; i++)
        {
            switch(ops[i])
            {
                case "+":
                    list.Add(list[^1] + list[^2]);
                    break;
                case "C":
                    list.RemoveAt(list.Count - 1);
                    break;
                case "D":
                    list.Add(list[^1] * 2);
                    break;
                default:
                    list.Add(int.Parse(ops[i]));
                    break;
            }
        }

        return list.Sum(x => x);
    }
}