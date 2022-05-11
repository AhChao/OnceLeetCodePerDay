using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-sorted-vowel-strings/
    public class L1641CountSortedVowelStringsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1641CountSortedVowelStrings = new L1641CountSortedVowelStrings();
        }

        private L1641CountSortedVowelStrings _l1641CountSortedVowelStrings;
        private int _i;

        [Test]
        public void Input_1_Should_Return_5()
        {
            _i = 1;
            ResultShouldBe(5);
        }

        [Test]
        public void Input_2_Should_Return_15()
        {
            _i = 2;
            ResultShouldBe(15);
        }

        [Test]
        public void Input_33_Should_Return_66045()
        {
            _i = 33;
            ResultShouldBe(66045);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1641CountSortedVowelStrings.CountVowelStrings(_i));
        }
    }
}