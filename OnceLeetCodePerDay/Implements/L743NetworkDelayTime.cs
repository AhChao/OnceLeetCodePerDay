using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L743NetworkDelayTime
{
    private int _maxDistance;
    private Dictionary<int, int> _nodeMinimumDistFromStart;
    private int[][] _list;

    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        _list = times;
        _maxDistance = -1;
        _nodeMinimumDistFromStart = new Dictionary<int, int>();
        for(int i = 1; i <= n; i++)
        {
            _nodeMinimumDistFromStart.Add(i, int.MaxValue);
        }

        _nodeMinimumDistFromStart[k] = 0;
        if(times.Count(x => x[0] == k) == 0)
        {
            return -1;
        }

        FindMaxDistance(k, 0);
        return _nodeMinimumDistFromStart.Count(x => x.Value == int.MaxValue) > 0
                   ? -1
                   : _nodeMinimumDistFromStart.Max(x => x.Value);
    }

    private void FindMaxDistance(int startNode, int distance)
    {
        var fromNodeList = _list.Where(x => x[0] == startNode).OrderBy(x => x[2]);
        var fromNodeListCount = fromNodeList.Count();
        if(fromNodeListCount == 0)
        {
            return;
        }

        foreach(var nodeData in fromNodeList)
        {
            var distanceNow = distance + nodeData[2];
            if(_nodeMinimumDistFromStart[nodeData[1]] > distanceNow)
            {
                _nodeMinimumDistFromStart[nodeData[1]] = distanceNow;
                FindMaxDistance(nodeData[1], distance + nodeData[2]);
            }
        }
    }
}