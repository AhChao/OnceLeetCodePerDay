using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/rings-and-rods/
    public class L2103RingsAndRodsTests
    {
        private L2103RingsAndRods _l2103RingsAndRods;
        private string _rings;

        [Test]
        public void Example1_Should_Return_1()
        {
            _l2103RingsAndRods = new L2103RingsAndRods();
            _rings = "B0B6G0R6R0R6G9";
            ResultShouldBe(1);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _l2103RingsAndRods = new L2103RingsAndRods();
            _rings = "B0R0G0R9R0B0G0";
            ResultShouldBe(1);
        }

        [Test]
        public void Example3_Should_Return_0()
        {
            _l2103RingsAndRods = new L2103RingsAndRods();
            _rings = "G4";
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2103RingsAndRods.CountPoints(_rings));
        }
    }
}