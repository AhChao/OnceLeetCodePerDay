using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/remove-outermost-parentheses/
    public class L1021RemoveOutermostParenthesesTests
    {
        private L1021RemoveOutermostParentheses _l1021RemoveOutermostParentheses;
        private string _s;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l1021RemoveOutermostParentheses = new L1021RemoveOutermostParentheses();
            _s = "(()())(())";
            ResultShouldBe("()()()");
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l1021RemoveOutermostParentheses = new L1021RemoveOutermostParentheses();
            _s = "(()())(())(()(()))";
            ResultShouldBe("()()()()(())");
        }


        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l1021RemoveOutermostParentheses = new L1021RemoveOutermostParentheses();
            _s = "()()";
            ResultShouldBe("");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1021RemoveOutermostParentheses.RemoveOuterParentheses(_s));
        }
    }
}