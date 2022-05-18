using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/split-a-string-in-balanced-strings/
    public class L1221SplitAStringInBalancedStringsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1221SplitAStringInBalancedStrings = new L1221SplitAStringInBalancedStrings();
        }

        private L1221SplitAStringInBalancedStrings _l1221SplitAStringInBalancedStrings;
        private string _s;

        [Test]
        public void Input_RLRRLLRLRL_Should_Return_4()
        {
            _s = "RLRRLLRLRL";
            ResultShouldBe(4);
        }

        [Test]
        public void Input_RLLLLRRRLR_Should_Return_3()
        {
            _s = "RLLLLRRRLR";
            ResultShouldBe(3);
        }

        [Test]
        public void Input_LLLLRRRR_Should_Return_1()
        {
            _s = "LLLLRRRR";
            ResultShouldBe(1);
        }

        [Test]
        public void Input_RLRRRLLRLL_Should_Return_2()
        {
            _s = "RLRRRLLRLL";
            ResultShouldBe(2);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1221SplitAStringInBalancedStrings.BalancedStringSplit(_s));
        }
    }
}