using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
    public class L2108FindFirstPalindromicStringInTheArrayTests
    {
        private L2108FindFirstPalindromicStringInTheArray _l2108FindFirstPalindromicStringInTheArray;
        private string[] _words;

        [Test]
        public void Example1_Should_Return_The_First_Palindromic_String()
        {
            _l2108FindFirstPalindromicStringInTheArray = new L2108FindFirstPalindromicStringInTheArray();
            _words = new[] {"abc", "car", "ada", "racecar", "cool"};
            ResultShouldBe("ada");
        }

        [Test]
        public void Example2_Should_Return_The_Empty_String()
        {
            _l2108FindFirstPalindromicStringInTheArray = new L2108FindFirstPalindromicStringInTheArray();
            _words = new[] {"def", "ghi"};
            ResultShouldBe("");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l2108FindFirstPalindromicStringInTheArray.FirstPalindrome(_words));
        }
    }
}