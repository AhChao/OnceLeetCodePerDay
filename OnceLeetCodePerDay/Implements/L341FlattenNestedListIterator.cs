using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class NestedInteger
{
    private int _value;

    private IList<NestedInteger> _list;

    public NestedInteger(int value)
    {
        _value = value;
        _list = null;
    }

    public NestedInteger(IList<NestedInteger> list)
    {
        _value = -1;
        _list = list;
    }

    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    public bool IsInteger()
    {
        return _list == null;
    }

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    public int GetInteger()
    {
        return _value;
    }

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    public IList<NestedInteger> GetList()
    {
        return _list;
    }
}

public class NestedIterator
{
    private List<int> _listOfNums = new List<int>();
    private int _index = -1;
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        FlattenNestedIntegerList(nestedList, _listOfNums);
    }

    private void FlattenNestedIntegerList(IList<NestedInteger> nestedList, List<int> list)
    {
        for (var i = 0; i < nestedList.Count; i++)
        {
            if (nestedList[i].IsInteger())
            {
                if (nestedList[i].GetInteger() != null)
                {
                    list.Add(nestedList[i].GetInteger());
                }
            }
            else
            {
                FlattenNestedIntegerList(nestedList[i].GetList(), list);
            }
        }
    }

    public bool HasNext()
    {
        return _index < _listOfNums.Count - 1;
    }

    public int Next()
    {
        return _listOfNums[++_index];
    }
}