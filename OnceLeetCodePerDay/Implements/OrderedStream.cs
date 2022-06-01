using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class OrderedStream
{
    private string[] _arr { get; set; }
    private int _ptr;

    public OrderedStream(int n)
    {
        _ptr = 0;
        _arr = new string[n];
    }

    public IList<string> Insert(int idKey, string value)
    {
        _arr[idKey - 1] = value;
        var list = new List<string>();
        for(var i = 0; i < _arr.Length; i++)
        {
            if(i == _ptr && _arr[i] != null)
            {
                list.Add(_arr[i]);
                _ptr++;
            }
        }

        return list;
    }
}