using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    public class L34FindFirstAndLastPositionOfElementInSortedArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l34FindFirstAndLastPositionOfElementInSortedArray =
                new L34FindFirstAndLastPositionOfElementInSortedArray();
        }

        private L34FindFirstAndLastPositionOfElementInSortedArray _l34FindFirstAndLastPositionOfElementInSortedArray;
        private int[] _nums;
        private int _target;
        private int[] _expect;

        [Test]
        public void Example1_Should_Return_3_4()
        {
            _nums = new[] {5, 7, 7, 8, 8, 10};
            _target = 8;
            _expect = new[] {3, 4};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Return_n1_n1()
        {
            _nums = new[] {5, 7, 7, 8, 8, 10};
            _target = 6;
            _expect = new[] {-1, -1};
            CheckTheResult();
        }

        [Test]
        public void Example3_Should_Return_n1_n1()
        {
            _nums = new int[] { };
            _target = 0;
            _expect = new[] {-1, -1};
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l34FindFirstAndLastPositionOfElementInSortedArray.SearchRange(_nums, _target).Should()
                                                              .BeEquivalentTo(_expect,
                                                                              rule => rule.WithStrictOrdering());
        }
    }
}