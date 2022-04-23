using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/range-sum-of-bst/
    public class L938RangeSumOfBSTTests
    {
        [Test]
        public void Example1_Result_Should_Be_32()
        {
            var l938RangeSumOfBst = new L938RangeSumOfBST();
            var root = new TreeNode(10, new TreeNode(5, new TreeNode(3), new TreeNode(7)),
                                    new TreeNode(15, null, new TreeNode(18)));
            var low = 7;
            var high = 15;
            Assert.AreEqual(32,l938RangeSumOfBst.RangeSumOfBst(root,low,high));
        }
    }
}