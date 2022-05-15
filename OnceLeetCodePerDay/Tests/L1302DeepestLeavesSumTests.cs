using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/deepest-leaves-sum/
    public class L1302DeepestLeavesSumTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1302DeepestLeavesSum = new L1302DeepestLeavesSum();
        }

        private L1302DeepestLeavesSum _l1302DeepestLeavesSum;
        private TreeNode _root;

        [Test]
        public void Example1_Should_Return_15()
        {
            _root = new TreeNode(1, new TreeNode(2, new TreeNode(4, new TreeNode(7), null), new TreeNode(5)),
                                 new TreeNode(3, null, new TreeNode(6, null, new TreeNode(8))));
            ResultShouldBe(15);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1302DeepestLeavesSum.DeepestLeavesSum(_root));
        }
    }
}