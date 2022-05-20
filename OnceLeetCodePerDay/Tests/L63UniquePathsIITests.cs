using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/unique-paths-ii/
    public class L63UniquePathsIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l63UniquePathsIi = new L63UniquePathsII();
        }

        private L63UniquePathsII _l63UniquePathsIi;
        private int[][] _obstacleGrid;

        [Test]
        public void Example1_Should_Return_2()
        {
            _obstacleGrid = new int[][] {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 0}};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _obstacleGrid = new int[][] {new[] {0, 1}, new[] {0, 0}};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l63UniquePathsIi.UniquePathsWithObstacles(_obstacleGrid));
        }
    }
}