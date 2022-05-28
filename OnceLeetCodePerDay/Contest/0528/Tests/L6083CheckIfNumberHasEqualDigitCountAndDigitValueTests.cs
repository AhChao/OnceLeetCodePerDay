using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0528.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-79/problems/check-if-number-has-equal-digit-count-and-digit-value/
    public class L6083CheckIfNumberHasEqualDigitCountAndDigitValueTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6083CheckIfNumberHasEqualDigitCountAndDigitValue =
                new L6083CheckIfNumberHasEqualDigitCountAndDigitValue();
        }

        private L6083CheckIfNumberHasEqualDigitCountAndDigitValue _l6083CheckIfNumberHasEqualDigitCountAndDigitValue;
        private string _num;

        [Test]
        public void Example1_Should_Return_True()
        {
            _num = "1210";
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Return_False()
        {
            _num = "030";
            ResultShouldBe(false);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l6083CheckIfNumberHasEqualDigitCountAndDigitValue.DigitCount(_num));
        }
    }
}