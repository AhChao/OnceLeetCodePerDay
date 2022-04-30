using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0430.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-77/problems/count-unguarded-cells-in-the-grid/
    public class L6053CountUnguardedCellsInTheGridTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6053CountUnguardedCellsInTheGrid = new L6053CountUnguardedCellsInTheGrid();
        }

        private L6053CountUnguardedCellsInTheGrid _l6053CountUnguardedCellsInTheGrid;
        private int _m;
        private int _n;
        private int[][] _guards;
        private int[][] _walls;

        [Test]
        public void Example1_Should_Be_As_Same_As_Expected()
        {
            _m = 4;
            _n = 6;
            _guards = new int[][] {new[] {0, 0}, new[] {1, 1}, new[] {2, 3}};
            _walls = new int[][] {new[] {0, 1}, new[] {2, 2}, new[] {1, 4}};
            ResultShouldBe(7);
        }

        [Test]
        public void Example2_Should_Be_As_Same_As_Expected()
        {
            _m = 3;
            _n = 3;
            _guards = new int[][] {new[] {1, 1}};
            _walls = new int[][] {new[] {0, 1}, new[] {1, 0}, new[] {2, 1}, new[] {1, 2}};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Be_As_Same_As_Expected()
        {
            _m = 5;
            _n = 5;
            _guards = new int[][] {new[] {1, 4}, new[] {4, 1}, new[] {0, 3}};
            _walls = new int[][] {new[] {3, 2}};
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l6053CountUnguardedCellsInTheGrid.CountUnguarded(_m, _n, _guards, _walls));
        }
    }
}