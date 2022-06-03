namespace OnceLeetCodePerDay.Implements;

public class L897IncreasingOrderSearchTree
{
    private TreeNode _dummy;

    public TreeNode IncreasingBST(TreeNode root)
    {
        _dummy = new TreeNode(-1);
        var result = _dummy;
        PreOrderVisit(root);
        return result.right;
    }

    private void PreOrderVisit(TreeNode root)
    {
        if(root == null)
        {
            return;
        }

        PreOrderVisit(root.left);
        _dummy.right = new TreeNode(root.val);
        _dummy = _dummy.right;
        PreOrderVisit(root.right);
    }
}