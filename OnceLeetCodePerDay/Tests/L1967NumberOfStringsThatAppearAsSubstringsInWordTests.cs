using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/
    public class L1967NumberOfStringsThatAppearAsSubstringsInWordTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1967NumberOfStringsThatAppearAsSubstringsInWord = new L1967NumberOfStringsThatAppearAsSubstringsInWord();
        }

        private L1967NumberOfStringsThatAppearAsSubstringsInWord _l1967NumberOfStringsThatAppearAsSubstringsInWord;
        private string[] _patterns;
        private string _word;

        [Test]
        public void Example1_Should_Return_3()
        {
            _patterns = new[] {"a", "abc", "bc", "d"};
            _word = "abc";
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_2()
        {
            _patterns = new[] {"a", "b", "c"};
            _word = "aaaaabbbbb";
            ResultShouldBe(2);
        }

        [Test]
        public void Example3_Should_Return_3()
        {
            _patterns = new[] {"a", "a", "a"};
            _word = "ab";
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1967NumberOfStringsThatAppearAsSubstringsInWord.NumOfStrings(_patterns, _word));
        }
    }
}