using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/check-if-a-string-contains-all-binary-codes-of-size-k/
    public class L1461CheckIfAStringContainsAllBinaryCodesOfSizeKTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1461CheckIfAStringContainsAllBinaryCodesOfSizeK = new L1461CheckIfAStringContainsAllBinaryCodesOfSizeK();
        }

        private L1461CheckIfAStringContainsAllBinaryCodesOfSizeK _l1461CheckIfAStringContainsAllBinaryCodesOfSizeK;
        private string _s;
        private int _k;

        [Test]
        public void Example1_Should_Return_true()
        {
            _s = "00110110";
            _k = 2;
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Return_true()
        {
            _s = "0110";
            _k = 1;
            ResultShouldBe(true);
        }

        [Test]
        public void Example3_Should_Return_false()
        {
            _s = "0110";
            _k = 2;
            ResultShouldBe(false);
        }

        [Test]
        public void Example4_Should_Return_false()
        {
            _s = "0";
            _k = 20;
            ResultShouldBe(false);
        }

        [Test]
        public void Example5_Should_Return_false()
        {
            _s = "1";
            _k = 1;
            ResultShouldBe(false);
        }

        [Test]
        public void Example6_Should_Return_false()
        {
            _s = "00110";
            _k = 2;
            ResultShouldBe(true);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l1461CheckIfAStringContainsAllBinaryCodesOfSizeK.HasAllCodes(_s, _k));
        }
    }
}