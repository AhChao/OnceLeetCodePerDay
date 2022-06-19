using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/find-the-highest-altitude/
    public class L1732FindTheHighestAltitudeTests
    {
        private L1732FindTheHighestAltitude _l1732FindTheHighestAltitude;
        private int[] _gain;

        [Test]
        public void Example1_Max_Altitude_Should_Be_1()
        {
            _l1732FindTheHighestAltitude = new L1732FindTheHighestAltitude();
            _gain = new[] {-5, 1, 5, 0, -7};
            ResultShouldBe(1);
        }

        [Test]
        public void Example2_Max_Altitude_Should_Be_0()
        {
            _l1732FindTheHighestAltitude = new L1732FindTheHighestAltitude();
            _gain = new[] {-4, -3, -2, -1, 4, 3, 2};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1732FindTheHighestAltitude.LargestAltitude(_gain));
        }
    }
}