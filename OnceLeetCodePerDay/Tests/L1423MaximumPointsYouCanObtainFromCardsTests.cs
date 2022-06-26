using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
    public class L1423MaximumPointsYouCanObtainFromCardsTests
    {
        private L1423MaximumPointsYouCanObtainFromCards _l1423MaximumPointsYouCanObtainFromCards;

        [Test]
        public void all_take_from_the_beginning()
        {
            _l1423MaximumPointsYouCanObtainFromCards = new L1423MaximumPointsYouCanObtainFromCards();
            MaxResultByTakeKCardsIs(15, new[] {6, 5, 4, 3, 2}, 3);
        }

        [Test]
        public void first_equal_but_second_should_take_left()
        {
            _l1423MaximumPointsYouCanObtainFromCards = new L1423MaximumPointsYouCanObtainFromCards();
            MaxResultByTakeKCardsIs(13, new[] {4, 5, 4, 3, 4}, 3);
        }

        [Test]
        public void first_equal_but_second_should_take_right()
        {
            _l1423MaximumPointsYouCanObtainFromCards = new L1423MaximumPointsYouCanObtainFromCards();
            MaxResultByTakeKCardsIs(13, new[] {4, 3, 4, 5, 4}, 3);
        }


        [Test]
        public void even_is_smaller_in_beginning_need_to_start_from_that_side()
        {
            _l1423MaximumPointsYouCanObtainFromCards = new L1423MaximumPointsYouCanObtainFromCards();
            MaxResultByTakeKCardsIs(13, new[] {1, 2, 7, 1, 1, 2, 3}, 4);
        }


        private void MaxResultByTakeKCardsIs(int expected, int[] cardPoints, int k)
        {
            Assert.AreEqual(expected, _l1423MaximumPointsYouCanObtainFromCards.MaxScore(cardPoints, k));
        }
    }
}