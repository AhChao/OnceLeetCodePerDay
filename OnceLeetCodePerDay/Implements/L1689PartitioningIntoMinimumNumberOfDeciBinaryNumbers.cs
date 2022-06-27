using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers
{
    public int MinPartitions(string n)
    {
        return int.Parse(n.Max().ToString());
    }
}