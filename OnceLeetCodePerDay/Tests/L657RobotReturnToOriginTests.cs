using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/robot-return-to-origin/
    public class L657RobotReturnToOriginTests
    {
        [SetUp]
        public void SetUp()
        {
            _l657RobotReturnToOrigin = new L657RobotReturnToOrigin();
        }

        private L657RobotReturnToOrigin _l657RobotReturnToOrigin;
        private string _moves;

        [Test]
        public void Input_UD_Should_Return_true()
        {
            _moves = "UD";
            ResultShouldBe(true);
        }

        [Test]
        public void Input_LL_Should_Return_false()
        {
            _moves = "LL";
            ResultShouldBe(false);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l657RobotReturnToOrigin.JudgeCircle(_moves));
        }
    }
}