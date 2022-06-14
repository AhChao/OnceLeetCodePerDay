using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0611.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-80/problems/match-substring-after-replacement/
    public class L6097MatchSubstringAfterReplacementTests
    {
        private L6097MatchSubstringAfterReplacement _l6097MatchSubstringAfterReplacement;
        private string _s;
        private string _sub;
        private char[][] _mappings;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l6097MatchSubstringAfterReplacement = new L6097MatchSubstringAfterReplacement();
            _s = "fool3e7bar";
            _sub = "leet";
            _mappings = new char[][] {new[] {'e', '3'}, new[] {'t', '7'}, new[] {'t', '8'}};
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l6097MatchSubstringAfterReplacement = new L6097MatchSubstringAfterReplacement();
            _s = "fooleetbar";
            _sub = "f00l";
            _mappings = new char[][] {new[] {'o', '0'}};
            ResultShouldBe(false);
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l6097MatchSubstringAfterReplacement = new L6097MatchSubstringAfterReplacement();
            _s = "Fool33tbaR";
            _sub = "leetd";
            _mappings = new char[][]
                        {new[] {'e', '3'}, new[] {'t', '7'}, new[] {'t', '8'}, new[] {'d', 'b'}, new[] {'p', 'b'}};
            ResultShouldBe(true);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l6097MatchSubstringAfterReplacement.MatchReplacement(_s, _sub, _mappings));
        }
    }
}