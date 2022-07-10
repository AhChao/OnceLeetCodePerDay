using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1354ConstructTargetArrayWithMultipleSums
{
    public bool IsPossible(int[] target)
    {
        var priorityQueue = new PriorityQueue<int, int>();
        var total = 0;
        foreach(var t in target)
        {
            priorityQueue.Enqueue(t, int.MaxValue - t);
            total += t;
        }

        while(priorityQueue.Peek() != 1)
        {
            var maxInQ = priorityQueue.Dequeue();

            total -= maxInQ;
            if(maxInQ <= total || total < 1)
            {
                return false;
            }

            var remain = maxInQ % total;
            total += remain;
            var push = remain == 0 ? total : remain;
            priorityQueue.Enqueue(push, int.MaxValue - push);
        }

        return true;
    }
}