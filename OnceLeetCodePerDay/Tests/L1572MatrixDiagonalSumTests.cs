using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/matrix-diagonal-sum/
    public class L1572MatrixDiagonalSumTests
    {
        private L1572MatrixDiagonalSum _l1572MatrixDiagonalSum;
        private int[][] _mat;

        [Test]
        public void Example1_Should_Return_25()
        {
            _l1572MatrixDiagonalSum = new L1572MatrixDiagonalSum();
            _mat = new int[][] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            ResultShouldBe(25);
        }

        [Test]
        public void Example2_Should_Return_8()
        {
            _l1572MatrixDiagonalSum = new L1572MatrixDiagonalSum();
            _mat = new int[][] {new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1}};
            ResultShouldBe(8);
        }

        [Test]
        public void Example3_Should_Return_5()
        {
            _l1572MatrixDiagonalSum = new L1572MatrixDiagonalSum();
            _mat = new int[][] {new[] {5}};
            ResultShouldBe(5);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1572MatrixDiagonalSum.DiagonalSum(_mat));
        }
    }
}