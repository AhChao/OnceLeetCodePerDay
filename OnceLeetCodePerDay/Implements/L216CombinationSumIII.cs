using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L216CombinationSumIII
{
    private List<IList<int>> _result;
    private List<int> _track;
    private int _maxCount;
    private int _targetSum;

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        _result = new List<IList<int>>();
        _track = new List<int>();
        _maxCount = k;
        _targetSum = n;
        BackTracking(1, _track);
        return _result;
    }

    private void BackTracking(int start, List<int> track)
    {
        if(track.Count == _maxCount && track.Sum() == _targetSum)
        {
            _result.Add(_track.ToList());
        }

        if(track.Count >= _maxCount || track.Sum() >= _targetSum)
        {
            return;
        }

        for(var i = start; i <= 9; i++)
        {
            track.Add(i);
            BackTracking(i + 1, track);
            track.RemoveAt(track.Count - 1);
        }
    }
}