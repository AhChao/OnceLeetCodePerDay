using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/intersection-of-two-arrays/
    public class L349IntersectionOfTwoArraysTests
    {
        private L349IntersectionOfTwoArrays _l349IntersectionOfTwoArrays;
        private int[] _nums1;
        private int[] _nums2;

        [Test]
        public void Example1_Should_Return_Unique_Intersection_Element()
        {
            _l349IntersectionOfTwoArrays = new L349IntersectionOfTwoArrays();
            _nums1 = new[] {1, 2, 2, 1};
            _nums2 = new[] {2, 2};
            ResultShouldBe(new[] {2});
        }

        [Test]
        public void Example2_Should_Return_Unique_Intersection_Element()
        {
            _l349IntersectionOfTwoArrays = new L349IntersectionOfTwoArrays();
            _nums1 = new[] {4, 9, 5};
            _nums2 = new[] {9, 4, 9, 8, 4};
            ResultShouldBe(new[] {4, 9});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l349IntersectionOfTwoArrays.Intersection(_nums1, _nums2).Should().BeEquivalentTo(expectation);
        }
    }
}