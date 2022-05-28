using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L268MissingNumber
{
    public int MissingNumber(int[] nums)
    {
        return (1 + nums.Length) * nums.Length / 2 - nums.Sum();
    }
}