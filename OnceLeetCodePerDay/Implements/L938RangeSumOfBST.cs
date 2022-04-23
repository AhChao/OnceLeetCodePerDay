namespace OnceLeetCodePerDay.Implements;

public class L938RangeSumOfBST
{
    private int _low;
    private int _high;
    private int _result;

    public int RangeSumOfBst(TreeNode root, int low, int high)
    {
        _low = low;
        _high = high;
        _result = 0;
        Traversal(root);
        return _result;
    }

    private void Traversal(TreeNode root)
    {
        if(root == null) return;
        if(root.val < _low) Traversal(root.right);
        if(root.val > _high) Traversal(root.left);
        if(root.val >= _low && root.val <= _high)
        {
            _result += root.val;
            Traversal(root.left);
            Traversal(root.right);
        }
    }
}