using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/counting-bits/
    public class L338CountingBitsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l338CountingBits = new L338CountingBits();
        }

        private L338CountingBits _l338CountingBits;
        private int _input;

        [Test]
        public void Input_2_Result_Should_Be_011()
        {
            _input = 2;
            ResultShouldBe(new[] {0, 1, 1});
        }

        [Test]
        public void Input_5_Result_Should_Be_011212()
        {
            _input = 5;
            ResultShouldBe(new[] {0, 1, 1, 2, 1, 2});
        }

        [Test]
        public void Input_8_Result_Should_Be_011212231()
        {
            _input = 8;
            ResultShouldBe(new[] {0, 1, 1, 2, 1, 2, 2, 3, 1});
        }

        private void ResultShouldBe(int[] expected)
        {
            _l338CountingBits.CountBits(_input).Should().Equal(expected);
        }
    }
}