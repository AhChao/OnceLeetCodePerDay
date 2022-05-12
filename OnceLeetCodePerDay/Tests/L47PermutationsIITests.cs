using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/permutations-ii/
    public class L47PermutationsIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l47PermutationsIi = new L47PermutationsII();
        }

        private L47PermutationsII _l47PermutationsIi;
        private int[] _nums;

        [Test]
        public void Input_112_Should_Return_3_Results()
        {
            _nums = new[] {1, 1, 2};
            ResultShouldBe(new List<List<int>>()
                           {
                               new() {1, 1, 2},
                               new() {1, 2, 1},
                               new() {2, 1, 1}
                           });
        }

        [Test]
        public void Input_123_Should_Return_6_Results()
        {
            _nums = new[] {1, 2, 3};
            ResultShouldBe(new List<List<int>>()
                           {
                               new() {1, 2, 3},
                               new() {1, 3, 2},
                               new() {2, 1, 3},
                               new() {2, 3, 1},
                               new() {3, 1, 2},
                               new() {3, 2, 1}
                           });
        }

        private void ResultShouldBe(List<List<int>> expected)
        {
            _l47PermutationsIi.PermuteUnique(_nums).Should().BeEquivalentTo(expected);
        }
    }
}