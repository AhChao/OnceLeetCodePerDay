namespace OnceLeetCodePerDay.Implements;

public class L1588SumOfAllOddLengthSubarrays
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        var sum = 0;
        for(var l = 1; l <= arr.Length; l += 2)
        {
            for(var i = 0; i < arr.Length - l + 1; i++)
            {
                var count = 0;
                while(count < l)
                {
                    sum += arr[i + count];
                    count++;
                }
            }
        }

        return sum;
    }
}