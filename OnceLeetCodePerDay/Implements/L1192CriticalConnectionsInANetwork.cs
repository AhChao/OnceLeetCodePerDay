using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1192CriticalConnectionsInANetwork
{
    private List<IList<int>> _bridges;
    private Dictionary<int, List<int>> _graph;
    private int _time;
    private int[] _dfn;
    private int[] _low;

    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
    {
        _time = 0;
        _bridges = new List<IList<int>>();
        _graph = new Dictionary<int, List<int>>();
        foreach(var connection in connections)
        {
            if(!_graph.ContainsKey(connection[0]))
            {
                _graph.Add(connection[0], new List<int>());
            }

            if(!_graph.ContainsKey(connection[1]))
            {
                _graph.Add(connection[1], new List<int>());
            }

            _graph[connection[0]].Add(connection[1]);
            _graph[connection[1]].Add(connection[0]);
        }

        _dfn = new int[n];
        _low = new int[n];
        Array.Fill(_dfn, -1);

        for(var i = 0; i < n; i++)
        {
            if(_dfn[i] == -1) //not visited
            {
                DFS(i, i);
            }
        }


        return _bridges;
    }

    private void DFS(int u, int parent)
    {
        _dfn[u] = _time;
        _low[u] = _time;
        _time++;
        for(var i = 0; i < _graph[u].Count; i++)
        {
            var v = _graph[u][i];
            if(v == parent)
            {
                continue;
            }

            if(_dfn[v] == -1)
            {
                DFS(v, u);
                _low[u] = Math.Min(_low[u], _low[v]);
            }

            if(_low[v] > _dfn[u])
            {
                _bridges.Add(new List<int>() {u, v});
            }
            else
            {
                _low[u] = Math.Min(_low[u], _dfn[v]);
            }
        }
    }
}