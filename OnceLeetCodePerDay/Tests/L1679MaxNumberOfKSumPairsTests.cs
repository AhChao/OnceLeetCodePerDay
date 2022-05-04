using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/max-number-of-k-sum-pairs/
    public class L1679MaxNumberOfKSumPairsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1679MaxNumberOfKSumPairs = new L1679MaxNumberOfKSumPairs();
        }

        private L1679MaxNumberOfKSumPairs _l1679MaxNumberOfKSumPairs;
        private int[] _nums;
        private int _k;

        [Test]
        public void Example1_Should_Return_2()
        {
            _nums = new[] {1, 2, 3, 4};
            _k = 5;
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _nums = new[] {3, 1, 3, 4, 3};
            _k = 6;
            ResultShouldBe(1);
        }

        [Test]
        public void Example3_Should_Return_0()
        {
            _nums = new[] {3, 1, 5, 1, 1, 1, 1, 1, 2, 2, 3, 2, 2};
            _k = 1;
            ResultShouldBe(0);
        }

        [Test]
        public void Example4_Should_Return_2()
        {
            _nums = new[] {2, 2, 2, 3, 1, 1, 4, 1};
            _k = 4;
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1679MaxNumberOfKSumPairs.MaxOperations(_nums, _k));
        }
    }
}