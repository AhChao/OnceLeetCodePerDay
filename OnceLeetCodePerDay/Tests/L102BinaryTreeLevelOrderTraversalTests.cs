using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/binary-tree-level-order-traversal/
    public class L102BinaryTreeLevelOrderTraversalTests
    {
        private L102BinaryTreeLevelOrderTraversal _l102BinaryTreeLevelOrderTraversal;
        private TreeNode _root;
        private List<List<int>> _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l102BinaryTreeLevelOrderTraversal = new L102BinaryTreeLevelOrderTraversal();
            _root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            _expected = new List<List<int>>() {new() {3}, new() {9, 20}, new() {15, 7}};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l102BinaryTreeLevelOrderTraversal = new L102BinaryTreeLevelOrderTraversal();
            _root = new TreeNode(1);
            _expected = new List<List<int>>() {new() {1}};
            CheckTheResult();
        }


        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l102BinaryTreeLevelOrderTraversal = new L102BinaryTreeLevelOrderTraversal();
            _root = null;
            _expected = new List<List<int>>() { };
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l102BinaryTreeLevelOrderTraversal.LevelOrder(_root).Should()
                                              .BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}