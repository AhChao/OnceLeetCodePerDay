using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/check-if-the-sentence-is-pangram/
    public class L1832CheckIfTheSentenceIsPangramTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1832CheckIfTheSentenceIsPangram = new L1832CheckIfTheSentenceIsPangram();
        }

        private L1832CheckIfTheSentenceIsPangram _l1832CheckIfTheSentenceIsPangram;
        private string _sentence;

        [Test]
        public void If_Is_Pangram_Should_Return_True()
        {
            _sentence = "thequickbrownfoxjumpsoverthelazydog";
            ResultShouldBe(true);
        }

        [Test]
        public void If_Not_Pangram_Should_Return_False()
        {
            _sentence = "leetcode";
            ResultShouldBe(false);
        }
        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l1832CheckIfTheSentenceIsPangram.CheckIfPangram(_sentence));
        }
    }
}