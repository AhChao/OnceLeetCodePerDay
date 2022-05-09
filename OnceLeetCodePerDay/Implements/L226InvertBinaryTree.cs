namespace OnceLeetCodePerDay.Implements;

public class L226InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        Traverse(root);
        return root;
    }

    private void Traverse(TreeNode root)
    {
        if(root == null)
        {
            return;
        }

        Traverse(root.left);
        Traverse(root.right);
        (root.left, root.right) = (root.right, root.left);
    }
}