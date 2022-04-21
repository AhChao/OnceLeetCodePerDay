using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
    public class L2011FinalValueOfVariableAfterPerformingOperationsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2011FinalValueOfVariableAfterPerformingOperations =
                new L2011FinalValueOfVariableAfterPerformingOperations();
        }

        private L2011FinalValueOfVariableAfterPerformingOperations _l2011FinalValueOfVariableAfterPerformingOperations;
        private string[] _operations;

        [Test]
        public void Example_1_Result_Should_Be_1()
        {
            _operations = new[] {"--X", "X++", "X++"};
            ResultShouldBe(1);
        }

        [Test]
        public void Example_2_Result_Should_Be_3()
        {
            _operations = new[] {"++X", "++X", "X++"};
            ResultShouldBe(3);
        }

        [Test]
        public void Example_3_Result_Should_Be_0()
        {
            _operations = new[] {"X++", "++X", "--X", "X--"};
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected,
                            _l2011FinalValueOfVariableAfterPerformingOperations
                                .FinalValueAfterOperations(_operations));
        }
    }
}