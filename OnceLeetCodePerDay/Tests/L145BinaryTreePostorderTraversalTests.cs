using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/binary-tree-postorder-traversal/
    public class L145BinaryTreePostorderTraversalTests
    {
        [SetUp]
        public void SetUp()
        {
            _l145BinaryTreePostorderTraversal = new L145BinaryTreePostorderTraversal();
        }

        private L145BinaryTreePostorderTraversal _l145BinaryTreePostorderTraversal;
        private TreeNode _root;
        private List<int> _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            _expected = new List<int>() {3, 2, 1};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _root = null;
            _expected = new List<int>() { };
            CheckTheResult();
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _root = new TreeNode(1);
            _expected = new List<int>() {1};
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l145BinaryTreePostorderTraversal.PostorderTraversal(_root).Should()
                                             .BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}