using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/fibonacci-number/
    public class L509FibonacciNumberTests
    {
        [SetUp]
        public void SetUp()
        {
            _l509FibonacciNumber = new L509FibonacciNumber();
        }

        private L509FibonacciNumber _l509FibonacciNumber;
        private int _n;

        [Test]
        public void Input_2_Should_Return_1()
        {
            _n = 2;
            ResultShouldBe(1);
        }

        [Test]
        public void Input_3_Should_Return_2()
        {
            _n = 3;
            ResultShouldBe(2);
        }

        [Test]
        public void Input_4_Should_Return_3()
        {
            _n = 4;
            ResultShouldBe(3);
        }

        [Test]
        public void Input_0_Should_Return_0()
        {
            _n = 0;
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l509FibonacciNumber.Fib(_n));
        }
    }
}