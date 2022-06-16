using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L145BinaryTreePostorderTraversal
{
    public IList<int> _result { get; set; }

    public IList<int> PostorderTraversal(TreeNode root)
    {
        _result = new List<int>();
        Traversal(root);
        return _result;
    }

    private void Traversal(TreeNode root)
    {
        if(root == null)
        {
            return;
        }

        if(root.left != null)
        {
            Traversal(root.left);
        }

        if(root.right != null)
        {
            Traversal(root.right);
        }

        _result.Add(root.val);
    }
}