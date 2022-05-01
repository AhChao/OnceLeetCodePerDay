using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0501.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/weekly-contest-291/problems/minimum-consecutive-cards-to-pick-up/
    //https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
    public class L6048MinimumConsecutiveCardsToPickUpTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6048MinimumConsecutiveCardsToPickUp = new L6048MinimumConsecutiveCardsToPickUp();
        }

        private L6048MinimumConsecutiveCardsToPickUp _l6048MinimumConsecutiveCardsToPickUp;
        private int[] _cards;

        [Test]
        public void Input_342347_Should_Return_4()
        {
            _cards = new[] {3, 4, 2, 3, 4, 7};
            ResultShouldBe(4);
        }

        [Test]
        public void Input_1053_Should_Return_Negative_1()
        {
            _cards = new[] {1, 0, 5, 3};
            ResultShouldBe(-1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l6048MinimumConsecutiveCardsToPickUp.MinimumCardPickup(_cards));
        }
    }
}