using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-equal-and-divisible-pairs-in-an-array/
    public class L2176CountEqualAndDivisiblePairsInAnArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2176CountEqualAndDivisiblePairsInAnArray = new L2176CountEqualAndDivisiblePairsInAnArray();
        }

        private L2176CountEqualAndDivisiblePairsInAnArray _l2176CountEqualAndDivisiblePairsInAnArray;
        private int[] _nums;
        private int _k;

        [Test]
        public void Example1_Should_Return_4()
        {
            _nums = new[] {3, 1, 2, 2, 2, 1, 3};
            _k = 2;
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_0()
        {
            _nums = new[] {1, 2, 3, 4};
            _k = 1;
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2176CountEqualAndDivisiblePairsInAnArray.CountPairs(_nums, _k));
        }
    }
}