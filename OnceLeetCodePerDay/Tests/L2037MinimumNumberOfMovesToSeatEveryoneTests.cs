using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/
    public class L2037MinimumNumberOfMovesToSeatEveryoneTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2037MinimumNumberOfMovesToSeatEveryone = new L2037MinimumNumberOfMovesToSeatEveryone();
        }

        private L2037MinimumNumberOfMovesToSeatEveryone _l2037MinimumNumberOfMovesToSeatEveryone;
        private int[] _seats;
        private int[] _students;

        [Test]
        public void Example1_Should_Return_4()
        {
            _seats = new[] {3, 1, 5};
            _students = new[] {2, 7, 4};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_7()
        {
            _seats = new[] {4, 1, 5, 9};
            _students = new[] {1, 3, 2, 6};
            ResultShouldBe(7);
        }

        [Test]
        public void Example3_Should_Return_4()
        {
            _seats = new[] {2, 2, 6, 6};
            _students = new[] {1, 3, 2, 6};
            ResultShouldBe(4);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2037MinimumNumberOfMovesToSeatEveryone.MinMovesToSeat(_seats, _students));
        }
    }
}