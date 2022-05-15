using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L590N_aryTreePostorderTraversal
{
    private List<int> _result;

    public IList<int> Postorder(NArrayTreeNode root)
    {
        _result = new List<int>();
        if(root == null) return _result;
        PostOrderTraverse(root);
        return _result;
    }

    private void PostOrderTraverse(NArrayTreeNode root)
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

public class NArrayTreeNode
{
    public int val;
    public IList<NArrayTreeNode> children;

    public NArrayTreeNode()
    {
    }

    public NArrayTreeNode(int _val)
    {
        val = _val;
    }

    public NArrayTreeNode(int _val, IList<NArrayTreeNode> _children)
    {
        val = _val;
        children = _children;
    }
}