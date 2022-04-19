using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/running-sum-of-1d-array/
    public class L1480RunningSumOf1dArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1480RunningSumOf1dArray = new L1480RunningSumOf1dArray();
        }

        private L1480RunningSumOf1dArray _l1480RunningSumOf1dArray;
        private int[] _nums;

        [Test]
        public void Input_1234_Should_Be_13610()
        {
            _nums = new[] {1, 2, 3, 4};
            ResultShouldBe(new[] {1, 3, 6, 10});
        }

        [Test]
        public void Input_11111_Should_Be_12345()
        {
            _nums = new[] {1, 1, 1, 1, 1};
            ResultShouldBe(new[] {1, 2, 3, 4, 5});
        }

        [Test]
        public void Input_1_Should_Be_1()
        {
            _nums = new[] {1};
            ResultShouldBe(new[] {1});
        }

        private void ResultShouldBe(int[] expected)
        {
            _l1480RunningSumOf1dArray.RunningSum(_nums).Should().BeEquivalentTo(expected);
        }
    }
}