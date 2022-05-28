using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Contest._0528.Implements;

public class L6085MaximumTotalImportanceOfRoads
{
    public long MaximumImportance(int n, int[][] roads)
    {
        var dictionary = new Dictionary<int, List<int>>();
        for(var i = 0; i < roads.Length; i++)
        {
            var point1 = roads[i][0];
            var point2 = roads[i][1];
            if(dictionary.ContainsKey(point1))
            {
                dictionary[point1].Add(point2);
            }
            else
            {
                dictionary.Add(point1, new List<int>() {point2});
            }

            if(dictionary.ContainsKey(point2))
            {
                dictionary[point2].Add(point1);
            }
            else
            {
                dictionary.Add(point2, new List<int>() {point1});
            }
        }

        var index = n;
        var dict2 = new Dictionary<int, int>();
        foreach(var keyValuePair in dictionary.OrderByDescending(x => x.Value.Count))
        {
            dict2.Add(keyValuePair.Key, index);
            index--;
        }

        long result = 0;
        foreach(var road in roads)
        {
            result += dict2[road[0]];
            result += dict2[road[1]];
        }

        return result;
    }
}