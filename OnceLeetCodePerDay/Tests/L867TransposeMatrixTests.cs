using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/transpose-matrix/
    public class L867TransposeMatrixTests
    {
        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            var l867TransposeMatrix = new L867TransposeMatrix();
            var matrix = new int[][] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var expectedMatrix = new int[][] {new[] {1, 4, 7}, new[] {2, 5, 8}, new[] {3, 6, 9}};
            l867TransposeMatrix.Transpose(matrix).Should().BeEquivalentTo(expectedMatrix);
        }
    }
}