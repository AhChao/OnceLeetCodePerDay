using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/3sum/
    public class L15_3SumTests
    {
        [SetUp]
        public void SetUp()
        {
            _l153Sum = new L15_3Sum();
        }

        private L15_3Sum _l153Sum;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _nums = new[] {-1, 0, 1, 2, -1, -4};
            ResultShouldBe(new List<List<int>>() {new() {-1, -1, 2}, new() {-1, 0, 1}});
        }

        [Test]
        public void Example1_Should_Return_As_Expected_TP()
        {
            _nums = new[] {-1, 0, 1, 2, -1, -4};
            TPResultShouldBe(new List<List<int>>() {new() {-1, -1, 2}, new() {-1, 0, 1}});
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _nums = new int[] { };
            ResultShouldBe(new List<List<int>>() { });
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _nums = new int[] {0};
            ResultShouldBe(new List<List<int>>() { });
        }

        private void ResultShouldBe(List<List<int>> expectation)
        {
            _l153Sum.ThreeSum(_nums).Should().BeEquivalentTo(expectation);
        }

        private void TPResultShouldBe(List<List<int>> expectation)
        {
            _l153Sum.ThreeSumTwoPointers(_nums).Should().BeEquivalentTo(expectation);
        }
    }
}