using System.Collections.Generic;

namespace OnceLeetCodePerDay.Contest._0528.Implements;

public class L6083CheckIfNumberHasEqualDigitCountAndDigitValue
{
    public bool DigitCount(string num)
    {
        var dictionary = new Dictionary<int, int>();
        for(var i = 0; i < num.Length; i++)
        {
            var key = int.Parse(num[i].ToString());
            if(dictionary.ContainsKey(key))
            {
                dictionary[key]++;
            }
            else
            {
                dictionary.Add(key, 1);
            }
        }

        for(var i = 0; i < num.Length; i++)
        {
            var numberInString = int.Parse(num[i].ToString());
            if(!dictionary.ContainsKey(i))
            {
                if(numberInString == 0)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            var numberInDictionary = dictionary[i];
            if(numberInString != numberInDictionary)
            {
                return false;
            }
        }

        return true;
    }
}