using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/remove-palindromic-subsequences/
    public class L1332RemovePalindromicSubsequencesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1332RemovePalindromicSubsequences = new L1332RemovePalindromicSubsequences();
        }

        private L1332RemovePalindromicSubsequences _l1332RemovePalindromicSubsequences;
        private string _s;

        [Test]
        public void Example1_Should_Return_1()
        {
            _s = "ababa";
            ResultShouldBe(1);
        }

        [Test]
        public void Example2_Should_Return_2()
        {
            _s = "abb";
            ResultShouldBe(2);
        }

        [Test]
        public void Example3_Should_Return_2()
        {
            _s = "abbaaaab";
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1332RemovePalindromicSubsequences.RemovePalindromeSub(_s));
        }
    }
}