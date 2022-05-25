using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
    public class L1614MaximumNestingDepthOfTheParenthesesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1614MaximumNestingDepthOfTheParentheses = new L1614MaximumNestingDepthOfTheParentheses();
        }

        private L1614MaximumNestingDepthOfTheParentheses _l1614MaximumNestingDepthOfTheParentheses;
        private string _s;

        [Test]
        public void Example1_Should_Return_3()
        {
            _s = "(1+(2*3)+((8)/4))+1";
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_3()
        {
            _s = "(1)+((2))+(((3)))";
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1614MaximumNestingDepthOfTheParentheses.MaxDepth(_s));
        }
    }
}