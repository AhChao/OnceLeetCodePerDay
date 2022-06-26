namespace OnceLeetCodePerDay.Implements;

public class L665NonDecreasingArray
{
    public bool CheckPossibility(int[] nums)
    {
        var foundOnce = false;
        for(var i = 0; i < nums.Length - 1; i++)
        {
            var nextEle = nums[i + 1];
            if(nums[i] > nextEle)
            {
                if(foundOnce)
                {
                    return false;
                }

                foundOnce = true;
                var lastEle = i - 1 >= 0 ? nums[i - 1] : int.MinValue;
                if(nextEle >= lastEle)
                {
                    nums[i] = lastEle;
                }
                else
                {
                    nums[i + 1] = nums[i];
                }
            }
        }

        return true;
    }
}