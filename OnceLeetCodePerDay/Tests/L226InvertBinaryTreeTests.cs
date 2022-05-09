using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/invert-binary-tree/
    public class L226InvertBinaryTreeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l226InvertBinaryTree = new L226InvertBinaryTree();
        }

        private TreeNode _root;
        private L226InvertBinaryTree _l226InvertBinaryTree;

        [Test]
        public void Input_4271369_Should_Return_4729631()
        {
            _root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)),
                                 new TreeNode(7, new TreeNode(6), new TreeNode(9)));

            ResultShouldBe(new TreeNode(4, new TreeNode(7, new TreeNode(9), new TreeNode(6)),
                                        new TreeNode(2, new TreeNode(3), new TreeNode(1))));
        }

        [Test]
        public void Input_213_Should_Return_231()
        {
            _root = new TreeNode(2, new TreeNode(1), new TreeNode(3));

            ResultShouldBe(new TreeNode(2, new TreeNode(3), new TreeNode(1)));
        }

        [Test]
        public void Input_null_Should_Return_null()
        {
            _root = null;

            ResultShouldBe(null);
        }

        [Test]
        public void Input_1n2_Should_Return_12n()
        {
            _root = new TreeNode(1, null, new TreeNode(2));

            ResultShouldBe(new TreeNode(1, new TreeNode(2), null));
        }

        private void ResultShouldBe(TreeNode expectation)
        {
            _l226InvertBinaryTree.InvertTree(_root).Should()
                                 .BeEquivalentTo(expectation);
        }
    }
}