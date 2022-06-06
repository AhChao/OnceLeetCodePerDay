using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/baseball-game/
    public class L682BaseballGameTests
    {
        [SetUp]
        public void SetUp()
        {
            _l682BaseballGame = new L682BaseballGame();
        }

        private L682BaseballGame _l682BaseballGame;
        private string[] _ops;

        [Test]
        public void Example1_Result_Should_Be_30()
        {
            _ops = new[] {"5", "2", "C", "D", "+"};
            ResultShouldBe(30);
        }

        [Test]
        public void Example2_Result_Should_Be_27()
        {
            _ops = new[] {"5", "-2", "4", "C", "D", "9", "+", "+"};
            ResultShouldBe(27);
        }

        [Test]
        public void Example3_Result_Should_Be_0()
        {
            _ops = new[] {"1", "C"};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l682BaseballGame.CalPoints(_ops));
        }
    }
}