using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/truncate-sentence/
    public class L1816TruncateSentenceTests
    {
        private L1816TruncateSentence _l1816TruncateSentence;
        private string _s;
        private int _k;

        [Test]
        public void Example1_Should_Return_First_4_Words()
        {
            _l1816TruncateSentence = new L1816TruncateSentence();
            _s = "Hello how are you Contestant";
            _k = 4;
            ResultShouldBe("Hello how are you");
        }

        [Test]
        public void Example2_Should_Return_First_4_Words()
        {
            _l1816TruncateSentence = new L1816TruncateSentence();
            _s = "What is the solution to this problem";
            _k = 4;
            ResultShouldBe("What is the solution");
        }

        [Test]
        public void Example3_Should_Return_First_5_Words()
        {
            _l1816TruncateSentence = new L1816TruncateSentence();
            _s = "chopper is not a tanuki";
            _k = 5;
            ResultShouldBe("chopper is not a tanuki");
        }

        private void ResultShouldBe(string helloHowAreYou)
        {
            Assert.AreEqual(helloHowAreYou, _l1816TruncateSentence.TruncateSentence(_s, _k));
        }
    }
}