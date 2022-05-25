namespace OnceLeetCodePerDay.Implements;

public class L34FindFirstAndLastPositionOfElementInSortedArray
{
    public int[] SearchRange(int[] nums, int target)
    {
        if(nums.Length == 0)
        {
            return new[] {-1, -1};
        }

        var left = 0;
        var right = nums.Length - 1;

        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            if(target == nums[mid])
            {
                right = mid - 1;
            }
            else if(target > nums[mid])
            {
                left = mid + 1;
            }
            else if(target < nums[mid])
            {
                right = mid - 1;
            }
        }

        if(left >= nums.Length || nums[left] != target)
        {
            left = -1;
        }


        var rightBound = left;
        if(rightBound != -1)
        {
            while(nums[rightBound] == target)
            {
                rightBound++;
                if(rightBound == nums.Length)
                {
                    break;
                }
            }

            rightBound--;
        }


        return new[] {left, rightBound};
    }
}