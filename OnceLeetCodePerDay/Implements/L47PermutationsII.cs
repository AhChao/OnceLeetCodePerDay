using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L47PermutationsII
{
    private IList<IList<int>> _result;
    private bool[] _used;

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        _result = new List<IList<int>>();
        _used = new bool[nums.Length];
        BackTracking(nums.OrderBy(x => x).ToArray(), new List<int>());
        return _result;
    }

    private void BackTracking(int[] nums, List<int> track)
    {
        if(track.Count == nums.Length)
        {
            _result.Add(track.ToList());
            return;
        }

        var start = int.MaxValue;
        for(var i = 0; i < nums.Length; i++)
        {
            if(_used[i] || start == nums[i]) continue;
            track.Add(nums[i]);
            _used[i] = true;
            start = nums[i];
            BackTracking(nums, track);
            _used[i] = false;
            track.RemoveAt(track.Count - 1);
        }
    }
}