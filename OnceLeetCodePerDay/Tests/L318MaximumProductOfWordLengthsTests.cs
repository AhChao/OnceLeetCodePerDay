using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-product-of-word-lengths/
    public class L318MaximumProductOfWordLengthsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l318MaximumProductOfWordLengths = new L318MaximumProductOfWordLengths();
        }

        private L318MaximumProductOfWordLengths _l318MaximumProductOfWordLengths;
        private string[] _words;

        [Test]
        public void Example1_Should_Return_16()
        {
            _words = new[] {"abcw", "baz", "foo", "bar", "xtfn", "abcdef"};
            ResultShouldBe(16);
        }

        [Test]
        public void Example2_Should_Return_4()
        {
            _words = new[] {"a", "ab", "abc", "d", "cd", "bcd", "abcd"};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Return_0()
        {
            _words = new[] {"a", "aa", "aaa", "aaaa"};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l318MaximumProductOfWordLengths.MaxProduct(_words));
        }
    }
}