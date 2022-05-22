using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/self-dividing-numbers/
    public class L728SelfDividingNumbersTests
    {
        [SetUp]
        public void SetUp()
        {
            _l728SelfDividingNumbers = new L728SelfDividingNumbers();
        }

        private L728SelfDividingNumbers _l728SelfDividingNumbers;
        private int _left;
        private int _right;
        private List<int> _expected;

        [Test]
        public void Input_1_22_Should_Return_As_Expected()
        {
            _left = 1;
            _right = 22;
            _expected = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22};
            CheckResult();
        }

        [Test]
        public void Input_47_85_Should_Return_As_Expected()
        {
            _left = 47;
            _right = 85;
            _expected = new List<int>() {48, 55, 66, 77};
            CheckResult();
        }

        private void CheckResult()
        {
            _l728SelfDividingNumbers.SelfDividingNumbers(_left, _right).Should().BeEquivalentTo(_expected);
        }
    }
}