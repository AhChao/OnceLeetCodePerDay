using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/longest-increasing-subsequence/
    public class L300LongestIncreasingSubsequenceTests
    {
        [SetUp]
        public void SetUp()
        {
            _l300LongestIncreasingSubsequence = new L300LongestIncreasingSubsequence();
        }

        private L300LongestIncreasingSubsequence _l300LongestIncreasingSubsequence;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_4()
        {
            _nums = new[] {10, 9, 2, 5, 3, 7, 101, 18};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_4()
        {
            _nums = new[] {0, 1, 0, 3, 2, 3};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Return_1()
        {
            _nums = new[] {7, 7, 7, 7, 7, 7, 7};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l300LongestIncreasingSubsequence.LengthOfLIS(_nums));
        }
    }
}