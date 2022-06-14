using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/delete-operation-for-two-strings/
    public class L583DeleteOperationForTwoStringsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l583DeleteOperationForTwoStrings = new L583DeleteOperationForTwoStrings();
        }

        private L583DeleteOperationForTwoStrings _l583DeleteOperationForTwoStrings;
        private string _word1;
        private string _word2;

        [Test]
        public void Example1_Should_Return_2()
        {
            _word1 = "sea";
            _word2 = "eat";
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_4()
        {
            _word1 = "leetcode";
            _word2 = "etco";
            ResultShouldBe(4);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l583DeleteOperationForTwoStrings.MinDistance(_word1, _word2));
        }
    }
}