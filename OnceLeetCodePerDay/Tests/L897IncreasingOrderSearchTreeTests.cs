using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/increasing-order-search-tree/
    public class L897IncreasingOrderSearchTreeTests
    {
        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            var l897IncreasingOrderSearchTree = new L897IncreasingOrderSearchTree();
            var root = new TreeNode(5,new TreeNode(1),new TreeNode(7));
            var expected = new TreeNode(1,null,new TreeNode(5,null,new TreeNode(7)));
            l897IncreasingOrderSearchTree.IncreasingBST(root).Should().BeEquivalentTo(expected);
        }
    }
}