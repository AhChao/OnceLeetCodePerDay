using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1465MaximumAreaOfAPieceOfCakeAfterHorizontalAndVerticalCuts
{
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
    {
        var hList = horizontalCuts.OrderBy(x => x).ToList();
        hList.Insert(0, 0);
        hList.Add(h);
        var vList = verticalCuts.OrderBy(x => x).ToList();
        vList.Insert(0, 0);
        vList.Add(w);
        long max = 0;
        hList = GenDist(hList);
        vList = GenDist(vList);

        max = (long)hList.Max() * (long)vList.Max();
        return (int)(max % 1000000007);
    }

    private List<int> GenDist(List<int> list)
    {
        for(var i = 1; i < list.Count; i++)
        {
            list[i - 1] = list[i] - list[i - 1];
        }

        list[^1] = 0;
        return list;
    }
}