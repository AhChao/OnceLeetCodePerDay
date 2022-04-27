using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/
    public class L2160MinimumSumOfFourDigitNumberAfterSplittingDigitsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2160MinimumSumOfFourDigitNumberAfterSplittingDigits =
                new L2160MinimumSumOfFourDigitNumberAfterSplittingDigits();
        }

        private L2160MinimumSumOfFourDigitNumberAfterSplittingDigits
            _l2160MinimumSumOfFourDigitNumberAfterSplittingDigits;

        private int _num;

        [Test]
        public void Input_2932_Result_Should_Be_52()
        {
            _num = 2932;
            ResultShouldBe(52);
        }

        [Test]
        public void Input_4009_Result_Should_Be_13()
        {
            _num = 4009;
            ResultShouldBe(13);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2160MinimumSumOfFourDigitNumberAfterSplittingDigits.MinimumSum(_num));
        }
    }
}