using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L128LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        var priorityQueue = new PriorityQueue<int, int>();
        foreach(var num in nums)
        {
            priorityQueue.Enqueue(num, num);
        }

        var max = 0;
        var streak = 0;
        var last = -1;
        while(priorityQueue.Count > 0)
        {
            var dequeue = priorityQueue.Dequeue();
            if(streak == 0)
            {
                streak = 1;
            }
            else
            {
                var diff = dequeue - last;
                if(diff == 0)
                {
                    continue;
                }

                if(diff == 1)
                {
                    streak++;
                }
                else
                {
                    max = max > streak ? max : streak;
                    streak = 1;
                }
            }

            last = dequeue;
        }

        return max > streak ? max : streak;
    }
}