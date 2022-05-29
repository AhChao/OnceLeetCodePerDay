using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    public class L108ConvertSortedArrayToBinarySearchTreeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l108ConvertSortedArrayToBinarySearchTree = new L108ConvertSortedArrayToBinarySearchTree();
        }

        private L108ConvertSortedArrayToBinarySearchTree _l108ConvertSortedArrayToBinarySearchTree;
        private int[] _nums;
        private TreeNode _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _nums = new[] {-10, -3, 0, 5, 9};
            _expected = new TreeNode(0, new TreeNode(-10, null, new TreeNode(-3)),
                                     new TreeNode(5, null, new TreeNode(9)));
            CheckResult();
        }

        private void CheckResult()
        {
            _l108ConvertSortedArrayToBinarySearchTree.SortedArrayToBST(_nums).Should().BeEquivalentTo(_expected);
        }
    }
}