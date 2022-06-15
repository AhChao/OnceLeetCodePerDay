using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/longest-string-chain/
    public class L1048LongestStringChainTests
    {
        private L1048LongestStringChain _l1048LongestStringChain;
        private string[] _words;

        [Test]
        public void Example1_Should_Return_4()
        {
            _l1048LongestStringChain = new L1048LongestStringChain();
            _words = new[] {"a", "b", "ba", "bca", "bda", "bdca"};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_5()
        {
            _l1048LongestStringChain = new L1048LongestStringChain();
            _words = new[] {"xbc", "pcxbcf", "xb", "cxbc", "pcxbc"};
            ResultShouldBe(5);
        }

        [Test]
        public void Example3_Should_Return_5()
        {
            _l1048LongestStringChain = new L1048LongestStringChain();
            _words = new[] {"abcd", "dbqca"};
            ResultShouldBe(1);
        }

        [Test]
        public void Example4_Should_Return_4()
        {
            _l1048LongestStringChain = new L1048LongestStringChain();
            _words = new[] {"a", "ab", "ac", "bd", "abc", "abd", "abdd"};
            ResultShouldBe(4);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1048LongestStringChain.LongestStrChain(_words));
        }
    }
}