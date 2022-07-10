using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/candy/
    public class L135CandyTests
    {
        private L135Candy _l135Candy;
        private int[] _ratings;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l135Candy = new L135Candy();
            _ratings = new[] {1, 0, 2};
            ResultShouldBe(5);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l135Candy = new L135Candy();
            _ratings = new[] {1, 2, 2};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l135Candy = new L135Candy();
            _ratings = new[] {1, 3, 2, 2, 1};
            ResultShouldBe(7);
        }

        [Test]
        public void Example4_Should_Return_As_Expected()
        {
            _l135Candy = new L135Candy();
            _ratings = new[] {1, 2, 87, 87, 87, 2, 1};
            ResultShouldBe(13);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l135Candy.Candy(_ratings));
        }
    }
}