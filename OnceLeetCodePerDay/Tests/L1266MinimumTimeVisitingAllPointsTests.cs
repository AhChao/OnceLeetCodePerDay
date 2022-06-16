using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/minimum-time-visiting-all-points/
    public class L1266MinimumTimeVisitingAllPointsTests
    {
        private L1266MinimumTimeVisitingAllPoints _l1266MinimumTimeVisitingAllPoints;
        private int[][] _points;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l1266MinimumTimeVisitingAllPoints = new L1266MinimumTimeVisitingAllPoints();
            _points = new int[][] {new[] {1, 1}, new[] {3, 4}, new[] {-1, 0}};
            ResultShouldBe(7);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l1266MinimumTimeVisitingAllPoints = new L1266MinimumTimeVisitingAllPoints();
            _points = new int[][] {new[] {3, 2}, new[] {-2, 2}};
            ResultShouldBe(5);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1266MinimumTimeVisitingAllPoints.MinTimeToVisitAllPoints(_points));
        }
    }
}