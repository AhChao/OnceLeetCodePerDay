using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/longest-consecutive-sequence/
    public class L128LongestConsecutiveSequenceTests
    {
        private L128LongestConsecutiveSequence _l128LongestConsecutiveSequence;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l128LongestConsecutiveSequence = new L128LongestConsecutiveSequence();
            _nums = new[] {100, 4, 200, 1, 3, 2};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l128LongestConsecutiveSequence = new L128LongestConsecutiveSequence();
            _nums = new[] {0, 3, 7, 2, 5, 8, 4, 6, 0, 1};
            ResultShouldBe(9);
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l128LongestConsecutiveSequence = new L128LongestConsecutiveSequence();
            _nums = new[] {1, 2, 0, 1};
            ResultShouldBe(3);
        }
        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l128LongestConsecutiveSequence.LongestConsecutive(_nums));
        }
    }
}