using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0611.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-80/problems/successful-pairs-of-spells-and-potions/
    public class L6096SuccessfulPairsOfSpellsAndPotionsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6096SuccessfulPairsOfSpellsAndPotions = new L6096SuccessfulPairsOfSpellsAndPotions();
        }

        private L6096SuccessfulPairsOfSpellsAndPotions _l6096SuccessfulPairsOfSpellsAndPotions;
        private int[] _spell;
        private int[] _potions;
        private long _success;
        private int[] _expected;

        [Test]
        public void Example1_Should_Be_As_Expected()
        {
            _spell = new[] {5, 1, 3};
            _potions = new[] {1, 2, 3, 4, 5};
            _success = 7;
            _expected = new[] {4, 0, 3};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Be_As_Expected()
        {
            _spell = new[] {3, 1, 2};
            _potions = new[] {8, 5, 8};
            _success = 16;
            _expected = new[] {2, 0, 2};
            CheckTheResult();
        }

        [Test]
        public void Example3_Should_Be_As_Expected()
        {
            _spell = new[] {16, 13, 7, 36, 16, 25, 22, 18, 29};
            _potions = new[] {38, 25};
            _success = 223;
            _expected = new[] {2, 2, 1, 2, 2, 2, 2, 2, 2};
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l6096SuccessfulPairsOfSpellsAndPotions.SuccessfulPairs(_spell, _potions, _success).Should()
                                                   .BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}