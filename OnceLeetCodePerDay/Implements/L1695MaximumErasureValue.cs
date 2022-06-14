namespace OnceLeetCodePerDay.Implements;

public class L1695MaximumErasureValue
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        var left = 0;
        var right = 0;
        var isMeetDuplicateValue = false;
        var numExisit = new bool[10001];
        var sum = 0;
        var max = 0;
        while(right < nums.Length)
        {
            var rightItem = nums[right];
            if(!numExisit[rightItem])
            {
                numExisit[rightItem] = true;
                sum += rightItem;
                max = sum > max ? sum : max;
            }
            else
            {
                isMeetDuplicateValue = true;
            }

            while(isMeetDuplicateValue)
            {
                var leftItem = nums[left];
                if(leftItem != rightItem)
                {
                    numExisit[leftItem] = false;
                    sum -= leftItem;
                }
                else
                {
                    isMeetDuplicateValue = false;
                }

                left++;
            }

            right++;
        }

        return max;
    }
}