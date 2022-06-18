using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/binary-tree-cameras/
    public class L968BinaryTreeCamerasTests
    {
        [SetUp]
        public void SetUp()
        {
            _l968BinaryTreeCameras = new L968BinaryTreeCameras();
        }

        private L968BinaryTreeCameras _l968BinaryTreeCameras;
        private TreeNode _root;

        [Test]
        public void Example1_Will_Need_1_Camera()
        {
            _root = new TreeNode(0, new TreeNode(0, new TreeNode(0), new TreeNode(0)), null);
            ResultShouldBe(1);
        }

        [Test]
        public void Example2_Will_Need_2_Camera()
        {
            _root = new TreeNode(0, new TreeNode(0, new TreeNode(0, new TreeNode(0, null, new TreeNode(0)))));
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l968BinaryTreeCameras.MinCameraCover(_root));
        }
    }
}