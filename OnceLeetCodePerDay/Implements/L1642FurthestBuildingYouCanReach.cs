using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1642FurthestBuildingYouCanReach
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var priorityQueue = new PriorityQueue<int, int>();
        long sumDis = 0;
        for(var i = 1; i < heights.Length; i++)
        {
            var dis = heights[i] - heights[i - 1];
            if(dis <= 0)
            {
                continue;
            }

            priorityQueue.Enqueue(dis, dis);

            if(priorityQueue.Count > ladders)
            {
                var dequeue = priorityQueue.Dequeue();
                sumDis += dequeue;
            }

            if(sumDis > bricks)
            {
                return i - 1;
            }
        }

        return heights.Length - 1;
    }
}