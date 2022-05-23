using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/find-center-of-star-graph/
    public class L1791FindCenterOfStarGraphTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1791FindCenterOfStarGraph = new L1791FindCenterOfStarGraph();
        }

        private L1791FindCenterOfStarGraph _l1791FindCenterOfStarGraph;
        private int[][] _edges;

        [Test]
        public void Example1_Center_Should_Be_2()
        {
            _edges = new int[][] {new[] {1, 2}, new[] {2, 3}, new[] {4, 2}};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Center_Should_Be_2()
        {
            _edges = new int[][] {new[] {1, 2}, new[] {5, 1}, new[] {1, 3}, new[] {1, 4}};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1791FindCenterOfStarGraph.FindCenter(_edges));
        }
    }
}