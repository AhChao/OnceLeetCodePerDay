using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L406QueueReconstructionByHeight
{
    public int[][] ReconstructQueue(int[][] people)
    {
        var orderedPeople = people.OrderByDescending(x => x[0]).ThenBy(x => x[1]);
        var result = new List<int[]>();
        foreach(var person in orderedPeople)
        {
            result.Insert(person[1], person);
        }

        return result.ToArray();
    }
}