using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/shortest-path-in-binary-matrix/
    public class L1091ShortestPathInBinaryMatrixTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1091ShortestPathInBinaryMatrix = new L1091ShortestPathInBinaryMatrix();
        }

        private L1091ShortestPathInBinaryMatrix _l1091ShortestPathInBinaryMatrix;
        private int[][] _grid;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _grid = new int[][] {new[] {0, 1}, new[] {1, 0}};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _grid = new int[][] {new[] {0, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Work_As_Expected()
        {
            _grid = new int[][] {new[] {1, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}};
            ResultShouldBe(-1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1091ShortestPathInBinaryMatrix.ShortestPathBinaryMatrix(_grid));
        }
    }
}