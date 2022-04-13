using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/root-equals-sum-of-children/
    public class L2236RootEqualsSumOfChildrenTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2236RootEqualsSumOfChildren = new L2236RootEqualsSumOfChildren();
        }

        private L2236RootEqualsSumOfChildren _l2236RootEqualsSumOfChildren;
        private TreeNode _root;

        [Test]
        public void Input_10_4_6_Result_Should_Be_True()
        {
            _root = setupAThreeNodeBinaryTreeByInts(10, 4, 6);
            OutputBoolShouldBe(true);
        }

        [Test]
        public void Input_5_3_1_Result_Should_Be_False()
        {
            _root = setupAThreeNodeBinaryTreeByInts(5, 3, 1);
            OutputBoolShouldBe(false);
        }

        private void OutputBoolShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l2236RootEqualsSumOfChildren.CheckTree(_root));
        }

        private static TreeNode setupAThreeNodeBinaryTreeByInts(int rootVal, int leftVal, int rightVal)
        {
            return new TreeNode(rootVal, new TreeNode(leftVal), new TreeNode(rightVal));
        }
    }
}