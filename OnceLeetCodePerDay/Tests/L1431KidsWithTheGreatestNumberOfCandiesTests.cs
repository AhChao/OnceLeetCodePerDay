using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    public class L1431KidsWithTheGreatestNumberOfCandiesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1431KidsWithTheGreatestNumberOfCandies = new L1431KidsWithTheGreatestNumberOfCandies();
        }

        private L1431KidsWithTheGreatestNumberOfCandies _l1431KidsWithTheGreatestNumberOfCandies;
        private int[] _candies;
        private int _extraCandies;
        private bool[] _expected;

        [Test]
        public void Example1_Result_Should_Be_As_Expected()
        {
            _candies = new[] {2, 3, 5, 1, 3};
            _extraCandies = 3;
            _expected = new[] {true, true, true, false, true};
            ResultValidate();
        }

        [Test]
        public void Example2_Result_Should_Be_As_Expected()
        {
            _candies = new[] {4, 2, 1, 2, 2};
            _extraCandies = 1;
            _expected = new[] {true, false, false, false, false};
            ResultValidate();
        }

        [Test]
        public void Example3_Result_Should_Be_As_Expected()
        {
            _candies = new[] {12, 1, 12};
            _extraCandies = 10;
            _expected = new[] {true, false, true};
            ResultValidate();
        }

        private void ResultValidate()
        {
            _l1431KidsWithTheGreatestNumberOfCandies.KidsWithCandies(_candies, _extraCandies).Should()
                                                    .BeEquivalentTo(_expected);
        }
    }
}