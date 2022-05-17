namespace OnceLeetCodePerDay.Implements;

public class L1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
{
    private TreeNode _target;

    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        _target = target;
        return Traverse(original, cloned);
    }

    private TreeNode Traverse(TreeNode original, TreeNode cloned)
    {
        TreeNode targetNode = null;
        if(original != null)
        {
            if(original == _target)
            {
                return cloned;
            }
            else
            {
                targetNode = Traverse(original.left, cloned.left);
                if(targetNode != null) return targetNode;
                targetNode = Traverse(original.right, cloned.right);
                if(targetNode != null) return targetNode;
            }
        }

        return null;
    }
}