using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/di-string-match/
    public class L942DIStringMatchTests
    {
        private L942DIStringMatch _l942DiStringMatch;
        private string _s;
        private int[] _expected;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l942DiStringMatch = new L942DIStringMatch();
            _s = "IDID";
            _expected = new[] {0, 4, 1, 3, 2};
            CheckTheResult();
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l942DiStringMatch = new L942DIStringMatch();
            _s = "III";
            _expected = new[] {0, 1, 2, 3};
            CheckTheResult();
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l942DiStringMatch = new L942DIStringMatch();
            _s = "DDI";
            _expected = new[] {3, 2, 0, 1};
            CheckTheResult();
        }

        private void CheckTheResult()
        {
            _l942DiStringMatch.DiStringMatch(_s).Should()
                              .BeEquivalentTo(_expected, rules => rules.WithStrictOrdering());
        }
    }
}