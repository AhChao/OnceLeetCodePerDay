using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/short-encoding-of-words/
    public class L820ShortEncodingOfWordsTests
    {
        private L820ShortEncodingOfWords _l820ShortEncodingOfWords;
        private string[] _words;

        [Test]
        public void Example1_Should_Return_10()
        {
            _l820ShortEncodingOfWords = new L820ShortEncodingOfWords();
            _words = new[] {"time", "me", "bell"};
            ResultShouldBe(10);
        }

        [Test]
        public void Example2_Should_Return_2()
        {
            _l820ShortEncodingOfWords = new L820ShortEncodingOfWords();
            _words = new[] {"t"};
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l820ShortEncodingOfWords.MinimumLengthEncoding(_words));
        }
    }
}