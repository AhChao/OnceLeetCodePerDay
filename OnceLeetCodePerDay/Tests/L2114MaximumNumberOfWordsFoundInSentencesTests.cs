using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
    public class L2114MaximumNumberOfWordsFoundInSentencesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2114MaximumNumberOfWordsFoundInSentences = new L2114MaximumNumberOfWordsFoundInSentences();
        }

        private L2114MaximumNumberOfWordsFoundInSentences _l2114MaximumNumberOfWordsFoundInSentences;
        private string[] _sentences;

        [Test]
        public void Result_Of_Example1_Should_Be_6()
        {
            _sentences = new string[]
                         {"alice and bob love leetcode", "i think so too", "this is great thanks very much"};
            MaxNumberOfWordsShouldBe(6);
        }

        [Test]
        public void Result_Of_Example2_Should_Be_3()
        {
            _sentences = new string[]
                         {"please wait", "continue to fight", "continue to win"};
            MaxNumberOfWordsShouldBe(3);
        }

        private void MaxNumberOfWordsShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l2114MaximumNumberOfWordsFoundInSentences.MostWordsFound(_sentences));
        }
    }
}