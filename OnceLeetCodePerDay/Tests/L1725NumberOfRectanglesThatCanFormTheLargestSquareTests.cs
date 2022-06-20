using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/
    public class L1725NumberOfRectanglesThatCanFormTheLargestSquareTests
    {
        private L1725NumberOfRectanglesThatCanFormTheLargestSquare _l1725NumberOfRectanglesThatCanFormTheLargestSquare;
        private int[][] _rectangles;

        [Test]
        public void Example1_Should_Return_3()
        {
            _l1725NumberOfRectanglesThatCanFormTheLargestSquare =
                new L1725NumberOfRectanglesThatCanFormTheLargestSquare();
            _rectangles = new int[][] {new[] {5, 8}, new[] {3, 9}, new[] {5, 12}, new[] {16, 5}};
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_3()
        {
            _l1725NumberOfRectanglesThatCanFormTheLargestSquare =
                new L1725NumberOfRectanglesThatCanFormTheLargestSquare();
            _rectangles = new int[][] {new[] {2, 3}, new[] {3, 7}, new[] {4, 3}, new[] {3, 7}};
            ResultShouldBe(3);
        }

        [Test]
        public void Example3_Should_Return_1()
        {
            _l1725NumberOfRectanglesThatCanFormTheLargestSquare =
                new L1725NumberOfRectanglesThatCanFormTheLargestSquare();
            _rectangles = new int[][] {new[] {5, 8}, new[] {3, 9}, new[] {3, 12}};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected,
                            _l1725NumberOfRectanglesThatCanFormTheLargestSquare.CountGoodRectangles(_rectangles));
        }
    }
}