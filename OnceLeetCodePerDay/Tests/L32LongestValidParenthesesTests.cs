using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/longest-valid-parentheses/
    public class L32LongestValidParenthesesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l32LongestValidParentheses = new L32LongestValidParentheses();
        }

        private L32LongestValidParentheses _l32LongestValidParentheses;
        private string _s;

        [Test]
        public void Example1_Should_Be_2()
        {
            _s = "(()";
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Be_4()
        {
            _s = ")()())";
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Be_0()
        {
            _s = "";
            ResultShouldBe(0);
        }

        [Test]
        public void Example4_Should_Be_2()
        {
            _s = "()(()";
            ResultShouldBe(2);
        }

        [Test]
        public void Example5_Should_Be_6()
        {
            _s = "()(())(()(";
            ResultShouldBe(6);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l32LongestValidParentheses.LongestValidParentheses(_s));
        }
    }
}