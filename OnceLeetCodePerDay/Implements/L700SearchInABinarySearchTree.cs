namespace OnceLeetCodePerDay.Implements;

public class L700SearchInABinarySearchTree
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while(root != null)
        {
            if(root.val == val)
            {
                return root;
            }

            if(root.val < val)
            {
                root = root.right;
            }
            else
            {
                root = root.left;
            }
        }

        return null;
    }
}