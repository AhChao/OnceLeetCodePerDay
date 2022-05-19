using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/longest-increasing-path-in-a-matrix/
    public class L329LongestIncreasingPathInAMatrixTests
    {
        [SetUp]
        public void SetUp()
        {
            _l329LongestIncreasingPathInAMatrix = new L329LongestIncreasingPathInAMatrix();
        }

        private L329LongestIncreasingPathInAMatrix _l329LongestIncreasingPathInAMatrix;
        private int[][] _matrix;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _matrix = new int[][] {new[] {9, 9, 4}, new[] {6, 6, 8}, new[] {2, 1, 1}};
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _matrix = new int[][] {new[] {3, 4, 5}, new[] {3, 2, 6}, new[] {2, 2, 1}};
            ResultShouldBe(4);
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _matrix = new int[][] {new[] {1}};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l329LongestIncreasingPathInAMatrix.LongestIncreasingPath(_matrix));
        }
    }
}