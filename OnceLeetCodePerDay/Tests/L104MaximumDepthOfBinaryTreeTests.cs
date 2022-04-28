using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class L104MaximumDepthOfBinaryTreeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l104MaximumDepthOfBinaryTree = new L104MaximumDepthOfBinaryTree();
        }

        private L104MaximumDepthOfBinaryTree _l104MaximumDepthOfBinaryTree;
        private TreeNode _root;

        [Test]
        public void Example1_Max_Depth_Should_Be_3()
        {
            _root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            MaxDepthShouldBe(3);
        }

        [Test]
        public void Example2_Max_Depth_Should_Be_2()
        {
            _root = new TreeNode(1, null, new TreeNode(2));
            MaxDepthShouldBe(2);
        }

        private void MaxDepthShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l104MaximumDepthOfBinaryTree.MaxDepth(_root));
        }
    }
}