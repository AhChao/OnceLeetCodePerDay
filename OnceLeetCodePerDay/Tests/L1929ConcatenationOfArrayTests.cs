using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/concatenation-of-array/
    public class L1929ConcatenationOfArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1929ConcatenationOfArray = new L1929ConcatenationOfArray();
        }

        private L1929ConcatenationOfArray _l1929ConcatenationOfArray;
        private int[] _input;

        [Test]
        public void Result_Of_121_Should_Be_121121()
        {
            _input = new[] {1, 2, 1};
            ResultShouldBe(new[] {1, 2, 1, 1, 2, 1});
        }

        [Test]
        public void Result_Of_1321_Should_Be_13211321()
        {
            _input = new[] {1, 3, 2, 1};
            ResultShouldBe(new[] {1, 3, 2, 1, 1, 3, 2, 1});
        }

        private void ResultShouldBe(int[] expected)
        {
            _l1929ConcatenationOfArray.GetConcatenation(_input).Should().Equal(expected);
        }
    }
}