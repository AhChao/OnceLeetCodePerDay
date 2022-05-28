using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/missing-number/
    public class L268MissingNumberTests
    {
        [SetUp]
        public void SetUp()
        {
            _l268MissingNumber = new L268MissingNumber();
        }

        private L268MissingNumber _l268MissingNumber;
        private int[] _nums;

        [Test]
        public void Example1_Should_Return_2()
        {
            _nums = new[] {3, 0, 1};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_2()
        {
            _nums = new[] {0, 1};
            ResultShouldBe(2);
        }

        [Test]
        public void Example3_Should_Return_8()
        {
            _nums = new[] {9, 6, 4, 2, 3, 5, 7, 0, 1};
            ResultShouldBe(8);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l268MissingNumber.MissingNumber(_nums));
        }
    }
}