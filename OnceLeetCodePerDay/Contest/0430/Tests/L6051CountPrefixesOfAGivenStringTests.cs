using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0430.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-77/problems/count-prefixes-of-a-given-string/
    //https://leetcode.com/problems/count-prefixes-of-a-given-string/
    public class L6051CountPrefixesOfAGivenStringTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6051CountPrefixesOfAGivenString = new L6051CountPrefixesOfAGivenString();
        }

        private L6051CountPrefixesOfAGivenString _l6051CountPrefixesOfAGivenString;
        private string[] _words;
        private string _s;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _words = new[] {"a", "b", "c", "ab", "bc", "abc"};
            _s = "abc";
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _words = new[] {"a", "a"};
            _s = "aa";
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l6051CountPrefixesOfAGivenString.CountPrefixes(_words, _s));
        }
    }
}