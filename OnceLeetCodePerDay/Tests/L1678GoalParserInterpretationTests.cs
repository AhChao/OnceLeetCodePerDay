using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/goal-parser-interpretation/
    public class L1678GoalParserInterpretationTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1678GoalParserInterpretation = new L1678GoalParserInterpretation();
        }

        private L1678GoalParserInterpretation _l1678GoalParserInterpretation;
        private string _command;

        [Test]
        public void Example1_Should_Return_Goal()
        {
            _command = "G()(al)";
            ResultShouldBe("Goal");
        }

        [Test]
        public void Example2_Should_Return_Goal()
        {
            _command = "G()()()()(al)";
            ResultShouldBe("Gooooal");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1678GoalParserInterpretation.Interpret(_command));
        }
    }
}