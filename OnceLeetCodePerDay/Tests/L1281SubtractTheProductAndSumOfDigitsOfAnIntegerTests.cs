using NUnit.Framework;
using OnceLeetCodePerDay.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    public class L1281SubtractTheProductAndSumOfDigitsOfAnIntegerTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1281SubtractTheProductAndSumOfDigitsOfAnInteger = new L1281SubtractTheProductAndSumOfDigitsOfAnInteger();
        }

        private L1281SubtractTheProductAndSumOfDigitsOfAnInteger _l1281SubtractTheProductAndSumOfDigitsOfAnInteger;
        private int _n;

        [Test]
        public void Input_234_Should_Return_15()
        {
            _n = 234;
            ResultShouldBe(15);
        }

        [Test]
        public void Input_4421_Should_Return_21()
        {
            _n = 4421;
            ResultShouldBe(21);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1281SubtractTheProductAndSumOfDigitsOfAnInteger.SubtractProductAndSum(_n));
        }
    }
}