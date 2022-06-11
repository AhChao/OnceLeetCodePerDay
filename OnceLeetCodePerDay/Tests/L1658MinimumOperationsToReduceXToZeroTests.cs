using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
    public class L1658MinimumOperationsToReduceXToZeroTests
    {
        private L1658MinimumOperationsToReduceXToZero _l1658MinimumOperationsToReduceXToZero;
        private int[] _nums;
        private int _x;

        [Test]
        public void Example1_Should_Return_2()
        {
            _l1658MinimumOperationsToReduceXToZero = new L1658MinimumOperationsToReduceXToZero();
            _nums = new[] {1, 1, 4, 2, 3};
            _x = 5;
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_n1()
        {
            _l1658MinimumOperationsToReduceXToZero = new L1658MinimumOperationsToReduceXToZero();
            _nums = new[] {5, 6, 7, 8, 9};
            _x = 4;
            ResultShouldBe(-1);
        }

        [Test]
        public void Example3_Should_Return_5()
        {
            _l1658MinimumOperationsToReduceXToZero = new L1658MinimumOperationsToReduceXToZero();
            _nums = new[] {3, 2, 20, 1, 1, 3};
            _x = 10;
            ResultShouldBe(5);
        }

        [Test]
        public void Example4_Should_Return_n1()
        {
            _l1658MinimumOperationsToReduceXToZero = new L1658MinimumOperationsToReduceXToZero();
            _nums = new[] {1, 1};
            _x = 3;
            ResultShouldBe(-1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1658MinimumOperationsToReduceXToZero.MinOperations(_nums, _x));
        }
    }
}