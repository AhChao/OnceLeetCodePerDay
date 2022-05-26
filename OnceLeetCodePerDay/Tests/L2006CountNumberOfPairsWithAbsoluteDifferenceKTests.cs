using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k/
    public class L2006CountNumberOfPairsWithAbsoluteDifferenceKTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2006CountNumberOfPairsWithAbsoluteDifferenceK = new L2006CountNumberOfPairsWithAbsoluteDifferenceK();
        }

        private L2006CountNumberOfPairsWithAbsoluteDifferenceK _l2006CountNumberOfPairsWithAbsoluteDifferenceK;
        private int _k;
        private int[] _nums;

        [Test]
        public void Example1_Should_Be_4()
        {
            _k = 1;
            _nums = new[] {1, 2, 2, 1};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Be_3()
        {
            _k = 2;
            _nums = new[] {3, 2, 1, 5, 4};
            ResultShouldBe(3);
        }

        [Test]
        public void Example3_Should_Be_0()
        {
            _k = 3;
            _nums = new[] {1, 3};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2006CountNumberOfPairsWithAbsoluteDifferenceK.CountKDifference(_nums, _k));
        }
    }
}