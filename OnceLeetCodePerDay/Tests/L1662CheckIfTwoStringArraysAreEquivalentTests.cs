using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
    public class L1662CheckIfTwoStringArraysAreEquivalentTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1662CheckIfTwoStringArraysAreEquivalent = new L1662CheckIfTwoStringArraysAreEquivalent();
        }

        private L1662CheckIfTwoStringArraysAreEquivalent _l1662CheckIfTwoStringArraysAreEquivalent;
        private string[] _word1;
        private string[] _word2;

        [Test]
        public void Example1_Should_Return_true()
        {
            _word1 = new[] {"ab", "c"};
            _word2 = new[] {"a", "bc"};
            ResultShouldBe(true);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l1662CheckIfTwoStringArraysAreEquivalent.ArrayStringsAreEqual(_word1, _word2));
        }
    }
}