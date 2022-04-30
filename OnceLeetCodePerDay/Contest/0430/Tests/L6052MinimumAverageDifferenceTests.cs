using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0430.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-77/problems/minimum-average-difference/
    public class L6052MinimumAverageDifferenceTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6052MinimumAverageDifference = new L6052MinimumAverageDifference();
        }

        private L6052MinimumAverageDifference _l6052MinimumAverageDifference;
        private int[] _nums;

        [Test]
        public void Input_253953_Result_Should_Be_3()
        {
            _nums = new[] {2, 5, 3, 9, 5, 3};
            ResultShouldBe(3);
        }

        [Test]
        public void Input_0_Result_Should_Be_0()
        {
            _nums = new[] {0};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l6052MinimumAverageDifference.MinimumAverageDifference(_nums));
        }
    }
}