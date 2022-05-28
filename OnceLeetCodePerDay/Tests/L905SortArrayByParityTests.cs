using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/sort-array-by-parity/
    public class L905SortArrayByParityTests
    {
        [SetUp]
        public void SetUp()
        {
            _l905SortArrayByParity = new L905SortArrayByParity();
        }

        private L905SortArrayByParity _l905SortArrayByParity;
        private int[] _nums;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _nums = new[] {3, 1, 2, 4};
            ResultShouldBe(new[] {2, 4, 1, 3});
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _nums = new[] {0};
            ResultShouldBe(new[] {0});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l905SortArrayByParity.SortArrayByParity(_nums).Should()
                                  .BeEquivalentTo(expectation, rules => rules.WithStrictOrdering());
        }
    }
}