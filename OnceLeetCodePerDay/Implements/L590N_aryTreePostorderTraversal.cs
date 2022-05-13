using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L590N_aryTreePostorderTraversal
{
    private List<int> _result;

    public IList<int> Postorder(Node590 root)
    {
        _result = new List<int>();
        if(root == null) return _result;
        PostOrderTraverse(root);
        return _result;
    }

    private void PostOrderTraverse(Node590 root)
    {
        if(root.children == null)
        {
            _result.Add(root.val);
            return;
        }

        for(var i = 0; i < root.children.Count; i++)
        {
            PostOrderTraverse(root.children[i]);
        }

        _result.Add(root.val);
    }
}

public class Node590
{
    public int val;
    public IList<Node590> children;

    public Node590()
    {
    }

    public Node590(int _val)
    {
        val = _val;
    }

    public Node590(int _val, IList<Node590> _children)
    {
        val = _val;
        children = _children;
    }
}