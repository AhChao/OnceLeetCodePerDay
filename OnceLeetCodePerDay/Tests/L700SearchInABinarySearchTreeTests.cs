using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/search-in-a-binary-search-tree/
    public class L700SearchInABinarySearchTreeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l700SearchInABinarySearchTree = new L700SearchInABinarySearchTree();
        }

        private L700SearchInABinarySearchTree _l700SearchInABinarySearchTree;
        private TreeNode _root;
        private int _val;
        private TreeNode _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
            _val = 2;
            _expected = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            CheckResult();
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7));
            _val = 5;
            _expected = null;
            CheckResult();
        }

        private void CheckResult()
        {
            _l700SearchInABinarySearchTree.SearchBST(_root, _val).Should().BeEquivalentTo(_expected);
        }
    }
}