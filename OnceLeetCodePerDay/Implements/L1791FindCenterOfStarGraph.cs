namespace OnceLeetCodePerDay.Implements;

public class L1791FindCenterOfStarGraph
{
    public int FindCenter(int[][] edges)
    {
        var arr = new int[edges.Length + 2];
        for(var i = 0; i < edges.Length; i++)
        {
            if(arr[edges[i][0]] > 0) return edges[i][0];
            if(arr[edges[i][1]] > 0) return edges[i][1];
            arr[edges[i][0]]++;
            arr[edges[i][1]]++;
        }

        return -1;
    }
}