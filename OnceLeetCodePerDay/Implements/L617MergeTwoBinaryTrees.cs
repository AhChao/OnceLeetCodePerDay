namespace OnceLeetCodePerDay.Implements;

public class L617MergeTwoBinaryTrees
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if(root1 == null) return root2;
        if(root2 == null) return root1;
        Traverse(root1, root2);
        return root1;
    }

    private void Traverse(TreeNode root1, TreeNode root2)
    {
        if(root1 == null || root2 == null) return;
        root1.val += root2.val;
        Traverse(root1.left, root2.left);
        Traverse(root1.right, root2.right);
        if(root1.left == null) root1.left = root2.left;
        if(root1.right == null) root1.right = root2.right;
    }
}