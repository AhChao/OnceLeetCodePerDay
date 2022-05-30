using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/divide-two-integers/
    public class L29DivideTwoIntegersTests
    {
        private L29DivideTwoIntegers _l29DivideTwoIntegers;
        private int _dividend;
        private int _divisor;

        [Test]
        public void Input_10_3_Should_Return_3()
        {
            _l29DivideTwoIntegers = new L29DivideTwoIntegers();
            _dividend = 10;
            _divisor = 3;
            ResultShouldBe(3);
        }

        [Test]
        public void Input_7_n3_Should_Return_n2()
        {
            _l29DivideTwoIntegers = new L29DivideTwoIntegers();
            _dividend = 7;
            _divisor = -3;
            ResultShouldBe(-2);
        }

        [Test]
        public void Input_intnMax_n1_Should_Return_intnMax()
        {
            _l29DivideTwoIntegers = new L29DivideTwoIntegers();
            _dividend = -int.MaxValue;
            _divisor = -1;
            ResultShouldBe(int.MaxValue);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l29DivideTwoIntegers.Divide(_dividend, _divisor));
        }
    }
}