using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/wiggle-subsequence/
    public class L376WiggleSubsequenceTests
    {
        private L376WiggleSubsequence _l376WiggleSubsequence;
        private int[] _nums;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _l376WiggleSubsequence = new L376WiggleSubsequence();
            _nums = new[] {1, 7, 4, 9, 2, 5};
            ResultShouldBe(6);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _l376WiggleSubsequence = new L376WiggleSubsequence();
            _nums = new[] {1, 17, 5, 10, 13, 15, 10, 5, 16, 8};
            ResultShouldBe(7);
        }

        [Test]
        public void Example3_Should_Work_As_Expected()
        {
            _l376WiggleSubsequence = new L376WiggleSubsequence();
            _nums = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l376WiggleSubsequence.WiggleMaxLength(_nums));
        }
    }
}