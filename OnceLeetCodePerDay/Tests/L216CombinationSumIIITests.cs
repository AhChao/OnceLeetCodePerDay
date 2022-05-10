using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/combination-sum-iii/
    public class L216CombinationSumIIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l216CombinationSumIii = new L216CombinationSumIII();
        }

        private L216CombinationSumIII _l216CombinationSumIii;
        private int _k;
        private int _n;

        [Test]
        public void Input_k3_n7_Should_Return_124()
        {
            _k = 3;
            _n = 7;
            ResultShouldBe(new List<List<int>>() {new() {1, 2, 4}});
        }

        [Test]
        public void Input_k3_n9_Should_Return_3Results()
        {
            _k = 3;
            _n = 9;
            ResultShouldBe(new List<List<int>>() {new() {1, 2, 6}, new() {1, 3, 5}, new() {2, 3, 4}});
        }

        [Test]
        public void Input_k4_n1_Should_Return_Empty()
        {
            _k = 4;
            _n = 1;
            ResultShouldBe(new List<List<int>>());
        }

        private void ResultShouldBe(List<List<int>> expectation)
        {
            _l216CombinationSumIii.CombinationSum3(_k, _n).Should().BeEquivalentTo(expectation);
        }
    }
}