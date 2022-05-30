using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public class L167TwoSumII_InputArrayIsSortedTests
    {
        [SetUp]
        public void SetUp()
        {
            _l167TwoSumIiInputArrayIsSorted = new L167TwoSumII_InputArrayIsSorted();
        }

        private L167TwoSumII_InputArrayIsSorted _l167TwoSumIiInputArrayIsSorted;
        private int[] _numbers;
        private int _target;

        [Test]
        public void Example1_Should_Return_Two_Element_Index_Sum_To_9()
        {
            _numbers = new[] {2, 7, 11, 15};
            _target = 9;
            ResultShouldBe(new[] {1, 2});
        }

        [Test]
        public void Example2_Should_Return_Two_Element_Index_Sum_To_6()
        {
            _numbers = new[] {2, 3, 4};
            _target = 6;
            ResultShouldBe(new[] {1, 3});
        }

        [Test]
        public void Example3_Should_Return_Two_Element_Index_Sum_To_n1()
        {
            _numbers = new[] {-1, 0};
            _target = -1;
            ResultShouldBe(new[] {1, 2});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l167TwoSumIiInputArrayIsSorted.TwoSum(_numbers, _target).Should().BeEquivalentTo(expectation);
        }
    }
}