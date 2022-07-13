using System.Collections.Generic;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L102BinaryTreeLevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        if(root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count != 0)
        {
            var list = new List<int>();
            var queueCount = queue.Count;
            for(int i = 0; i < queueCount; i++)
            {
                var dequeue = queue.Dequeue();
                if(dequeue.left != null)
                {
                    queue.Enqueue(dequeue.left);
                }

                if(dequeue.right != null)
                {
                    queue.Enqueue(dequeue.right);
                }

                list.Add(dequeue.val);
            }

            result.Add(list.ToList());
        }

        return result;
    }
}