using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/minimum-bit-flips-to-convert-number/
    public class L2220MinimumBitFlipsToConvertNumberTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2220MinimumBitFlipsToConvertNumber = new L2220MinimumBitFlipsToConvertNumber();
        }

        private L2220MinimumBitFlipsToConvertNumber _l2220MinimumBitFlipsToConvertNumber;
        private int _start;
        private int _goal;

        [Test]
        public void Make_10_To_7_Need_Min_3_Steps()
        {
            _start = 10;
            _goal = 7;
            ResultShouldBe(3);
        }

        [Test]
        public void Make_3_To_4_Need_Min_3_Steps()
        {
            _start = 3;
            _goal = 4;
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2220MinimumBitFlipsToConvertNumber.MinBitFlips(_start, _goal));
        }
    }
}