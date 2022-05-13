using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L117PopulatingNextRightPointersInEachNodeII
{
    public Node Connect(Node root)
    {
        if(root == null) return null;
        var nodes = new Queue<Node>();
        nodes.Enqueue(root);
        while(nodes.Count > 0)
        {
            var nodesCountInit = nodes.Count;
            for(var i = 0; i < nodesCountInit; i++)
            {
                var node = nodes.Dequeue();
                if(nodesCountInit - (i + 1) > 0)
                {
                    node.next = nodes.Peek();
                }
                else
                {
                    node.next = null;
                }

                if(node.left != null)
                {
                    nodes.Enqueue(node.left);
                }

                if(node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
            }
        }

        return root;
    }
}

public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node()
    {
    }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}