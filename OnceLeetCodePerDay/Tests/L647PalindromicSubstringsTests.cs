using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/palindromic-substrings/
    public class L647PalindromicSubstringsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l647PalindromicSubstrings = new L647PalindromicSubstrings();
        }

        private L647PalindromicSubstrings _l647PalindromicSubstrings;
        private string _s;

        [Test]
        public void Input_abc_Should_Return_3()
        {
            _s = "abc";
            ResultShouldBe(3);
        }

        [Test]
        public void Input_aaa_Should_Return_6()
        {
            _s = "aaa";
            ResultShouldBe(6);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l647PalindromicSubstrings.CountSubstrings(_s));
        }
    }
}