using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/min-cost-climbing-stairs/
    public class L746MinCostClimbingStairsTests
    {
        private L746MinCostClimbingStairs _l746MinCostClimbingStairs;
        private int[] _cost;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l746MinCostClimbingStairs = new L746MinCostClimbingStairs();
            _cost = new[] {10, 15, 20};
            ResultShouldBe(15);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l746MinCostClimbingStairs = new L746MinCostClimbingStairs();
            _cost = new[] {1, 100, 1, 1, 1, 100, 1, 1, 100, 1};
            ResultShouldBe(6);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l746MinCostClimbingStairs.MinCostClimbingStairs(_cost));
        }
    }
}