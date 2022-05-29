namespace OnceLeetCodePerDay.Implements;

public class L108ConvertSortedArrayToBinarySearchTree
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        
        return GenerateTree(nums, left, right);;
    }

    private TreeNode GenerateTree(int[] arr, int left, int right)
    {
        if(left > right)
        {
            return null;
        }

        var mid = (left + right) / 2;
        var treeNode = new TreeNode(arr[mid]);
        treeNode.left = GenerateTree(arr, left, mid - 1);
        treeNode.right = GenerateTree(arr, mid + 1, right);
        return treeNode;
    }
}