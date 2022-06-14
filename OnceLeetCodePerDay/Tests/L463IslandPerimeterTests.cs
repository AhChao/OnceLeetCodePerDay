using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/island-perimeter/
    public class L463IslandPerimeterTests
    {
        [SetUp]
        public void SetUp()
        {
            _l463IslandPerimeter = new L463IslandPerimeter();
        }

        private L463IslandPerimeter _l463IslandPerimeter;
        private int[][] _grid;

        [Test]
        public void Example1_Should_Return_16()
        {
            _grid = new int[][] {new[] {0, 1, 0, 0}, new[] {1, 1, 1, 0}, new[] {0, 1, 0, 0}, new[] {1, 1, 0, 0}};
            ResultShouldBe(16);
        }

        [Test]
        public void Example2_Should_Return_4()
        {
            _grid = new int[][] {new[] {1}};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Return_4()
        {
            _grid = new int[][] {new[] {1, 0}};
            ResultShouldBe(4);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l463IslandPerimeter.IslandPerimeter(_grid));
        }
    }
}