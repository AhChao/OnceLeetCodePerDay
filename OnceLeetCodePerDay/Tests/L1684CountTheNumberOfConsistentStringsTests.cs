using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-the-number-of-consistent-strings/
    public class L1684CountTheNumberOfConsistentStringsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1684CountTheNumberOfConsistentStrings = new L1684CountTheNumberOfConsistentStrings();
        }

        private L1684CountTheNumberOfConsistentStrings _l1684CountTheNumberOfConsistentStrings;
        private string _allowed;
        private string[] _words;

        [Test]
        public void Example1_Should_Return_2()
        {
            _allowed = "ab";
            _words = new[] {"ad", "bd", "aaab", "baa", "badab"};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_7()
        {
            _allowed = "abc";
            _words = new[] {"a", "b", "c", "ab", "ac", "bc", "abc"};
            ResultShouldBe(7);
        }

        [Test]
        public void Example3_Should_Return_4()
        {
            _allowed = "cad";
            _words = new[] {"cc", "acd", "b", "ba", "bac", "bad", "ac", "d"};
            ResultShouldBe(4);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1684CountTheNumberOfConsistentStrings.CountConsistentStrings(_allowed, _words));
        }
    }
}