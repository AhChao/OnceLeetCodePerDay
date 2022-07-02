using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L1710MaximumUnitsOnATruck
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        boxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();
        var total = 0;
        var index = 0;
        while(truckSize > 0 && index < boxTypes.Length)
        {
            if(boxTypes[index][0] > truckSize)
            {
                total += boxTypes[index][1] * truckSize;
                break;
            }
            else
            {
                total += boxTypes[index][1] * boxTypes[index][0];
                truckSize -= boxTypes[index][0];
            }

            index++;
        }

        return total;
    }
}