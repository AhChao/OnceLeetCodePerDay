using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay.Tests
{
    //https://leetcode.com/problems/add-two-integers/
    public class L2235AddTwoIntegersTests
    {
        private L2235AddTwoIntegers _l2235AddTwoIntegers;

        [SetUp]
        public void SetUp()
        {
            _l2235AddTwoIntegers = new L2235AddTwoIntegers();
        }

        [Test]
        public void Input_12_5_Should_Return_17()
        {
            Assert.AreEqual(17, _l2235AddTwoIntegers.Sum(12, 5));
        }

        [Test]
        public void Input_Negative_10_4_Should_Return_Negative_6()
        {
            Assert.AreEqual(-6, _l2235AddTwoIntegers.Sum(-10, 4));
        }
    }
}