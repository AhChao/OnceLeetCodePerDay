using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/longest-palindromic-substring/
    public class L5LongestPalindromicSubstringTests
    {
        [SetUp]
        public void SetUp()
        {
            _l5LongestPalindromicSubstring = new L5LongestPalindromicSubstring();
        }

        private L5LongestPalindromicSubstring _l5LongestPalindromicSubstring;
        private string _s;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _s = "babad";
            ResultShouldBe("bab".Length);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _s = "cbbd";
            ResultShouldBe("bb".Length);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l5LongestPalindromicSubstring.LongestPalindrome(_s).Length);
        }
    }
}