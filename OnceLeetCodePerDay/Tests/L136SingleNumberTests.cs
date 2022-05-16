using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/single-number/
    public class L136SingleNumberTests
    {
        [SetUp]
        public void SetUp()
        {
            _l136SingleNumber = new L136SingleNumber();
        }

        private L136SingleNumber _l136SingleNumber;
        private int[] _nums;

        [Test]
        public void Input_221_Should_Return_1()
        {
            _nums = new[] {2, 2, 1};
            ResultShouldBe(1);
        }

        [Test]
        public void Input_41212_Should_Return_4()
        {
            _nums = new[] {4, 1, 2, 1, 2};
            ResultShouldBe(4);
        }

        [Test]
        public void Input_1_Should_Return_1()
        {
            _nums = new[] {1};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l136SingleNumber.SingleNumber(_nums));
        }
    }
}