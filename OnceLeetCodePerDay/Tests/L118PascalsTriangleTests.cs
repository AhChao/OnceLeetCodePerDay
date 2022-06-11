using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/pascals-triangle/
    public class L118PascalsTriangleTests
    {
        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            var l118PascalsTriangle = new L118PascalsTriangle();
            var numRows = 5;
            var expected = new List<List<int>>()
                           {new() {1}, new() {1, 1}, new() {1, 2, 1}, new() {1, 3, 3, 1}, new() {1, 4, 6, 4, 1}};
            l118PascalsTriangle.Generate(5).Should().BeEquivalentTo(expected);
        }
    }
}