using System;
using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L1302DeepestLeavesSum
{
    public int DeepestLeavesSum(TreeNode root)
    {
        if(root == null) return 0;
        var treeNodesQueue = new Queue<TreeNode>();
        treeNodesQueue.Enqueue(root);

        while(treeNodesQueue.Count > 0)
        {
            var sum = 0;
            var size = treeNodesQueue.Count;
            for(var i = 0; i < size; i++)
            {
                var node = treeNodesQueue.Dequeue();
                sum += node.val;
                if(node.left != null) treeNodesQueue.Enqueue(node.left);
                if(node.right != null) treeNodesQueue.Enqueue(node.right);
            }

            if(treeNodesQueue.Count == 0)
            {
                return sum;
            }
        }

        throw new Exception();
    }
}