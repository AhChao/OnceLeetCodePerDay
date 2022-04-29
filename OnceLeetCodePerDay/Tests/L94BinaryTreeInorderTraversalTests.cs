using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/
    public class L94BinaryTreeInorderTraversalTests
    {
        [SetUp]
        public void SetUp()
        {
            _l94BinaryTreeInorderTraversal = new L94BinaryTreeInorderTraversal();
        }

        private L94BinaryTreeInorderTraversal _l94BinaryTreeInorderTraversal;
        private TreeNode _root;

        [Test]
        public void Input_1n23_Result_Should_Be_132()
        {
            _root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null));
            ResultShouldBe(new List<int>() {1, 3, 2});
        }

        [Test]
        public void Input_n_Result_Should_Be_n()
        {
            _root = null;
            ResultShouldBe(new List<int>());
        }

        [Test]
        public void Input_1_Result_Should_Be_1()
        {
            _root = new TreeNode(1);
            ResultShouldBe(new List<int>() {1});
        }

        private void ResultShouldBe(List<int> expected)
        {
            _l94BinaryTreeInorderTraversal.InorderTraversal(_root).Should().Equal(expected);
        }
    }
}