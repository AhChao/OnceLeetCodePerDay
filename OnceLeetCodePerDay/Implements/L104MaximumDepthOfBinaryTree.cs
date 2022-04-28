namespace OnceLeetCodePerDay.Implements;

public class L104MaximumDepthOfBinaryTree
{
    private int _maxDepth;

    public int MaxDepth(TreeNode root)
    {
        _maxDepth = 0;
        Traverse(root, 0);
        return _maxDepth;
    }

    private void Traverse(TreeNode root, int layer)
    {
        if(root != null)
        {
            Traverse(root.right, layer + 1);
            Traverse(root.left, layer + 1);
        }
        else
        {
            _maxDepth = _maxDepth > layer ? _maxDepth : layer;
        }
    }
}