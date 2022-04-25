using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/shuffle-the-array/
    public class L1470ShuffleTheArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1470ShuffleTheArray = new L1470ShuffleTheArray();
        }

        private L1470ShuffleTheArray _l1470ShuffleTheArray;
        private int[] _nums;
        private int _n;

        [Test]
        public void Input_251347_Should_Get_235417()
        {
            _nums = new[] {2, 5, 1, 3, 4, 7};
            _n = 3;
            ResultShouldBe(new[] {2, 3, 5, 4, 1, 7});
        }

        [Test]
        public void Input_13_Should_Get_13()
        {
            _nums = new[] {1, 3};
            _n = 1;
            ResultShouldBe(new[] {1, 3});
        }

        private void ResultShouldBe(int[] expected)
        {
            _l1470ShuffleTheArray.Shuffle(_nums, _n).Should().BeEquivalentTo(expected);
        }
    }
}