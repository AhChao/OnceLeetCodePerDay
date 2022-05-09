using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    public class L1342NumberOfStepsToReduceANumberToZeroTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1342NumberOfStepsToReduceANumberToZero = new L1342NumberOfStepsToReduceANumberToZero();
        }

        private L1342NumberOfStepsToReduceANumberToZero _l1342NumberOfStepsToReduceANumberToZero;
        private int _nums;

        [Test]
        public void Input_14_Should_Return_6()
        {
            _nums = 14;
            ResultShouldBe(6);
        }

        [Test]
        public void Input_8_Should_Return_4()
        {
            _nums = 8;
            ResultShouldBe(4);
        }

        [Test]
        public void Input_123_Should_Return_12()
        {
            _nums = 123;
            ResultShouldBe(12);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1342NumberOfStepsToReduceANumberToZero.NumberOfSteps(_nums));
        }
    }
}