using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/prefix-and-suffix-search/
    public class L745PrefixAndSuffixSearchTests
    {
        private string[] _words;
        private WordFilter _wordFilter;
        private string _prefix;
        private string _suffix;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _words = new[] {"apple"};
            _wordFilter = new WordFilter(_words);
            _prefix = "a";
            _suffix = "e";
            IndexInFilterShouldBe(0);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _words = new[] {"apple", "apple"};
            _wordFilter = new WordFilter(_words);
            _prefix = "a";
            _suffix = "e";
            IndexInFilterShouldBe(1);
        }

        [Test]
        public void Example3_Should_Work_As_Expected()
        {
            _words = new[] {"apple"};
            _wordFilter = new WordFilter(_words);
            _prefix = "a";
            _suffix = "d";
            IndexInFilterShouldBe(-1);
        }

        private void IndexInFilterShouldBe(int expected)
        {
            Assert.AreEqual(expected, _wordFilter.F(_prefix, _suffix));
        }
    }
}