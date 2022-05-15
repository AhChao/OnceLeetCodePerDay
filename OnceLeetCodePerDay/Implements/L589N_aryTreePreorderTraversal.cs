using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L589N_aryTreePreorderTraversal
{
    private List<int> _result;

    public IList<int> Preorder(NArrayTreeNode root)
    {
        _result = new List<int>();
        if(root == null) return _result;
        Traverse(root);
        return _result;
    }

    private void Traverse(NArrayTreeNode root)
    {
        _result.Add(root.val);
        if(root.children == null)
        {
            return;
        }

        for(var i = 0; i < root.children.Count; i++)
        {
            Traverse(root.children[i]);
        }
    }
}