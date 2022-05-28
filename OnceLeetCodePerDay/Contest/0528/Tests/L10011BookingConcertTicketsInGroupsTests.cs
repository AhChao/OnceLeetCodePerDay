using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0528.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-79/problems/booking-concert-tickets-in-groups/
    public class L10011BookingConcertTicketsInGroupsTests
    {
        private BookMyShow _bookMyShow;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _bookMyShow = new BookMyShow(2, 5);
            _bookMyShow.Gather(4, 0).Should().BeEquivalentTo(new[] {0, 0}, rules => rules.WithStrictOrdering());
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _bookMyShow = new BookMyShow(5, 9);
            _bookMyShow.Gather(10, 1);
            _bookMyShow.Scatter(3, 3);
            _bookMyShow.Gather(9, 1).Should().BeEquivalentTo(new[] {1, 0}, rules => rules.WithStrictOrdering());
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _bookMyShow = new BookMyShow(5, 9);
            _bookMyShow.Scatter(2, 2);
            _bookMyShow.Gather(7, 2);
            _bookMyShow.Gather(4, 1);
            _bookMyShow.Gather(6, 2);
            Assert.AreEqual(true, _bookMyShow.Scatter(2, 1));
        }

        [Test]
        public void Example4_Should_Return_As_Expected()
        {
            _bookMyShow = new BookMyShow(3, 999999999);
            Assert.AreEqual(true, _bookMyShow.Scatter(1000000000, 2));
            //Assert.AreEqual(true, _bookMyShow.Scatter(2, 1));
        }

        [Test]
        public void Example5_Should_Return_As_Expected()
        {
            _bookMyShow = new BookMyShow(5, 9);
            _bookMyShow.Gather(10, 1);
            _bookMyShow.Scatter(3, 3);
            _bookMyShow.Gather(9, 1);
            _bookMyShow.Gather(10, 2);
            _bookMyShow.Gather(2, 0).Should().BeEquivalentTo(new[] {0, 3});
        }
    }
}