using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/unique-morse-code-words/
    public class L804UniqueMorseCodeWordsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l804UniqueMorseCodeWords = new L804UniqueMorseCodeWords();
        }

        private L804UniqueMorseCodeWords _l804UniqueMorseCodeWords;
        private string[] _words;

        [Test]
        public void Example1_Should_Return_2()
        {
            _words = new[] {"gin", "zen", "gig", "msg"};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _words = new[] {"a"};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l804UniqueMorseCodeWords.UniqueMorseRepresentations(_words));
        }
    }
}