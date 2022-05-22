using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L728SelfDividingNumbers
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var result = new List<int>();
        for(int i = left; i <= right; i++)
        {
            var str = i.ToString();
            if(!str.Contains('0'))
            {
                var isValid = true;
                for(var j = 0; j < str.Length; j++)
                {
                    if(i % int.Parse(str.Substring(j, 1)) != 0)
                    {
                        isValid = false;
                        break;
                    }
                }

                if(isValid)
                {
                    result.Add(i);
                }
            }
        }

        return result;
    }
}