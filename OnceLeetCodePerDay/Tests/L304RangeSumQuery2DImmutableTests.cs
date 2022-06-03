using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/range-sum-query-2d-immutable/
    public class L304RangeSumQuery2DImmutableTests
    {
        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            var numMatrix = new NumMatrix(new int[][]{new []{3, 0, 1, 4, 2},new []{5, 6, 3, 2, 1}, new[]{1, 2, 0, 1, 5},new[]{4, 1, 0, 1, 7},new[]{1, 0, 3, 0, 5 }});
            Assert.AreEqual(8,numMatrix.SumRegion(2,1,4,3));
            Assert.AreEqual(11,numMatrix.SumRegion(1,1,2,2));
            Assert.AreEqual(12,numMatrix.SumRegion(1,2,2,4));
        }
    }
}