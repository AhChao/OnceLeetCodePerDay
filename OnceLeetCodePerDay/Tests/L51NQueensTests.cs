using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/n-queens/
    public class L51NQueensTests
    {
        [Test]
        public void Input_4_Should_Return_2_Results()
        {
            var l51NQueens = new L51NQueens();
            var expected = new List<List<string>>()
                           {
                               new List<string>() {".Q..", "...Q", "Q...", "..Q."},
                               new List<string>() {"..Q.", "Q...", "...Q", ".Q.."}
                           };
            l51NQueens.SolveNQueens(4).Should().BeEquivalentTo(expected, rules => rules.WithStrictOrdering());
        }
    }
}