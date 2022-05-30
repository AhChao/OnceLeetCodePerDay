using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    public class L26RemoveDuplicatesFromSortedArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l26RemoveDuplicatesFromSortedArray = new L26RemoveDuplicatesFromSortedArray();
        }

        private L26RemoveDuplicatesFromSortedArray _l26RemoveDuplicatesFromSortedArray;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_2()
        {
            _nums = new[] {1, 1, 2};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_5()
        {
            _nums = new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
            ResultShouldBe(5);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l26RemoveDuplicatesFromSortedArray.RemoveDuplicates(_nums));
            _nums.Take(expected).ToArray().Should()
                 .BeEquivalentTo(_nums.Distinct(), rules => rules.WithStrictOrdering());
        }
    }
}