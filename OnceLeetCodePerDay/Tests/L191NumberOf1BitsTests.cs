using System;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/number-of-1-bits/
    public class L191NumberOf1BitsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l191NumberOf1Bits = new L191NumberOf1Bits();
        }

        private L191NumberOf1Bits _l191NumberOf1Bits;
        private uint _n;

        [Test]
        public void Example1_Should_Return_3()
        {
            _n = Convert.ToUInt32("00000000000000000000000000001011", 2);
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _n = Convert.ToUInt32("00000000000000000000000010000000", 2);
            ResultShouldBe(1);
        }

        [Test]
        public void Example3_Should_Return_31()
        {
            _n = Convert.ToUInt32("11111111111111111111111111111101", 2);
            ResultShouldBe(31);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l191NumberOf1Bits.HammingWeight(_n));
        }
    }
}