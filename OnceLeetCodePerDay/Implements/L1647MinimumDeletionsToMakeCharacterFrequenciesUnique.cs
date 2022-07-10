using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1647MinimumDeletionsToMakeCharacterFrequenciesUnique
{
    public int MinDeletions(string s)
    {
        var groupByCount = s.GroupBy(x => x).Select(x => x.Count()).ToList();
        var uniqueCount = new HashSet<int>();
        var totalDeletions = 0;
        for(var i = 0; i < groupByCount.Count; i++)
        {
            while(uniqueCount.Contains(groupByCount[i]) && groupByCount[i] > 0)
            {
                groupByCount[i]--;
                totalDeletions++;
            }

            uniqueCount.Add(groupByCount[i]);
        }

        return totalDeletions;
    }
}