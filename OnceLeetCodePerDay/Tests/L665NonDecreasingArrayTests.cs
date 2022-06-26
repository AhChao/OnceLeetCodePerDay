using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/non-decreasing-array/
    public class L665NonDecreasingArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l665NonDecreasingArray = new L665NonDecreasingArray();
        }

        private L665NonDecreasingArray _l665NonDecreasingArray;
        private int[] _nums;

        [Test]
        public void Example1_Should_Be_True()
        {
            _nums = new[] {4, 2, 3};
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Be_True()
        {
            _nums = new[] {4, 2, 1};
            ResultShouldBe(false);
        }

        [Test]
        public void Example3_Should_Be_False()
        {
            _nums = new[] {3, 4, 2, 3};
            ResultShouldBe(false);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l665NonDecreasingArray.CheckPossibility(_nums));
        }
    }
}