using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/find-target-indices-after-sorting-array/
    public class L2089FindTargetIndicesAfterSortingArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2089FindTargetIndicesAfterSortingArray = new L2089FindTargetIndicesAfterSortingArray();
        }

        private L2089FindTargetIndicesAfterSortingArray _l2089FindTargetIndicesAfterSortingArray;
        private int[] _nums;
        private int _target;
        private List<int> _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _nums = new[] {1, 2, 5, 2, 3};
            _target = 2;
            _expected = new List<int> {1, 2};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _nums = new[] {1, 2, 5, 2, 3};
            _target = 3;
            _expected = new List<int> {3};
            CheckTheResult();
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _nums = new[] {1, 2, 5, 2, 3};
            _target = 5;
            _expected = new List<int> {4};
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l2089FindTargetIndicesAfterSortingArray.TargetIndices(_nums, _target).Should()
                                                    .BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}