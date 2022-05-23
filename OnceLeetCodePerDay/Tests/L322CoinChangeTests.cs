using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/coin-change/
    public class L322CoinChangeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l322CoinChange = new L322CoinChange();
        }

        private L322CoinChange _l322CoinChange;
        private int[] _coins;
        private int _amount;

        [Test]
        public void Example1_Should_Return_3()
        {
            _coins = new[] {1, 2, 5};
            _amount = 11;
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_n1()
        {
            _coins = new[] {2};
            _amount = 3;
            ResultShouldBe(-1);
        }

        [Test]
        public void Example3_Should_Return_0()
        {
            _coins = new[] {1};
            _amount = 0;
            ResultShouldBe(0);
        }

        [Test]
        public void Example4_Should_Return_2()
        {
            _coins = new[] {1, 2147483647};
            _amount = 2;
            ResultShouldBe(2);
        }

        [Test]
        public void Example5_Should_Return_20()
        {
            _coins = new[] {186, 419, 83, 408};
            _amount = 6249;
            ResultShouldBe(20);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l322CoinChange.CoinChange(_coins, _amount));
        }
    }
}