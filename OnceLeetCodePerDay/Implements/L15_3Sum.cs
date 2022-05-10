using System;
using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L15_3Sum
{
    private IList<IList<int>> _result;

    public IList<IList<int>> ThreeSum(int[] nums)
    {
        _result = new List<IList<int>>();
        var track = new List<int>();
        nums = nums.OrderBy(x => x).ToArray();
        BackTracking(nums, 0, track);
        return _result.DistinctBy(x => String.Join("", x.Select((y, index) => y + "_" + index)))
                      .ToList();
    }

    public IList<IList<int>> ThreeSumTwoPointers(int[] nums)
    {
        _result = new List<IList<int>>();
        nums = nums.OrderBy(x => x).ToArray();
        for(var i = 0; i < nums.Length;)
        {
            var nowValue = nums[i];
            var temp = TwoSumTarget(nums, i + 1, 0 - nowValue);
            temp.ForEach(x => x.Add(nowValue));
            temp.ForEach(x => _result.Add(x.ToList()));
            while(i < nums.Length && nums[i] == nowValue)
            {
                i++;
            }
        }

        return _result;
    }

    private List<IList<int>> TwoSumTarget(int[] nums, int start, int target)
    {
        var left = start;
        var right = nums.Length - 1;
        var temp = new List<IList<int>>();
        while(left < right)
        {
            var leftValue = nums[left];
            var rightValue = nums[right];
            var sum = leftValue + rightValue;
            if(sum > target)
            {
                right--;
            }
            else if(sum < target)
            {
                left++;
            }
            else
            {
                temp.Add(new List<int>() {leftValue, rightValue});
                while(left < right && leftValue == nums[left])
                {
                    left++;
                }

                while(left < right && rightValue == nums[right])
                {
                    right--;
                }
            }
        }

        return temp;
    }

    private void BackTracking(int[] nums, int start, List<int> track)
    {
        if(track.Sum() == 0 && track.Count == 3)
        {
            _result.Add(track.ToList());
        }

        if(track.Count == 3)
        {
            return;
        }

        for(var i = start; i < nums.Length; i++)
        {
            track.Add(nums[i]);
            BackTracking(nums, i + 1, track);
            track.RemoveAt(track.Count - 1);
        }
    }
}