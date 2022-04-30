using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0430.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-77/problems/minimum-average-difference/
    public class L6052MinimumAverageDifferenceTests
    {
        [Test]
        public void Input_253953_Result_Should_Be_3()
        {
            var l6052MinimumAverageDifference = new L6052MinimumAverageDifference();
            var nums = new[] { 2, 5, 3, 9, 5, 3 };
            Assert.AreEqual(3,l6052MinimumAverageDifference.MinimumAverageDifference(nums));
        }
    }
}