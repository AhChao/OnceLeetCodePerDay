using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/sorting-the-sentence/
    public class L1859SortingTheSentenceTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1859SortingTheSentence = new L1859SortingTheSentence();
        }

        private L1859SortingTheSentence _l1859SortingTheSentence;
        private string _s;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _s = "is2 sentence4 This1 a3";
            ResultShouldBe("This is a sentence");
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _s = "Myself2 Me1 I4 and3";
            ResultShouldBe("Me Myself and I");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1859SortingTheSentence.SortSentence(_s));
        }
    }
}