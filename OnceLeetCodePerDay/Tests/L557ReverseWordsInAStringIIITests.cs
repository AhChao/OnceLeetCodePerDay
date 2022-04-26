using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/reverse-words-in-a-string-iii/
    public class L557ReverseWordsInAStringIIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l557ReverseWordsInAStringIii = new L557ReverseWordsInAStringIII();
        }

        private L557ReverseWordsInAStringIII _l557ReverseWordsInAStringIii;
        private string _s;

        [Test]
        public void Example1_Result_Should_Be_As_Expected()
        {
            _s = "Let's take LeetCode contest";
            ResultShouldBe("s'teL ekat edoCteeL tsetnoc");
        }

        [Test]
        public void Example2_Result_Should_Be_As_Expected()
        {
            _s = "God Ding";
            ResultShouldBe("doG gniD");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l557ReverseWordsInAStringIii.ReverseWords(_s));
        }
    }
}