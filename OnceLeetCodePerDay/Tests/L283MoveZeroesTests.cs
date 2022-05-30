using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/move-zeroes/
    public class L283MoveZeroesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l283MoveZeroes = new L283MoveZeroes();
        }

        private L283MoveZeroes _l283MoveZeroes;
        private int[] _nums;
        private int[] _expected;

        [Test]
        public void Example1_All_0_Should_Move_To_Tail()
        {
            _nums = new[] {0, 1, 0, 3, 12};
            _expected = new[] {1, 3, 12, 0, 0};
            CheckResult();
        }

        [Test]
        public void Example2_All_0_Should_Move_To_Tail()
        {
            _nums = new[] {0};
            _expected = new[] {0};
            CheckResult();
        }

        private void CheckResult()
        {
            _l283MoveZeroes.MoveZeroes(_nums);
            _nums.Should().BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}