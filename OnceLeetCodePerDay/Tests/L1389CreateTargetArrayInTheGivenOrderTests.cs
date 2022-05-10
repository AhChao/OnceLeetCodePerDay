using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/create-target-array-in-the-given-order/
    public class L1389CreateTargetArrayInTheGivenOrderTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1389CreateTargetArrayInTheGivenOrder = new L1389CreateTargetArrayInTheGivenOrder();
        }

        private L1389CreateTargetArrayInTheGivenOrder _l1389CreateTargetArrayInTheGivenOrder;
        private int[] _nums;
        private int[] _index;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _nums = new[] {0, 1, 2, 3, 4};
            _index = new[] {0, 1, 2, 2, 1};
            ResultShouldBe(new[] {0, 4, 1, 3, 2});
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _nums = new[] {1, 2, 3, 4, 0};
            _index = new[] {0, 1, 2, 3, 0};
            ResultShouldBe(new[] {0, 1, 2, 3, 4});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l1389CreateTargetArrayInTheGivenOrder.CreateTargetArray(_nums, _index).Should().Equal(expectation);
        }
    }
}