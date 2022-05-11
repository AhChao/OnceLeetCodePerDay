using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/cells-in-a-range-on-an-excel-sheet/
    public class L2194CellsInARangeOnAnExcelSheetTests
    {
        [SetUp]
        public void SetUp()
        {
            _l2194CellsInARangeOnAnExcelSheet = new L2194CellsInARangeOnAnExcelSheet();
        }

        private L2194CellsInARangeOnAnExcelSheet _l2194CellsInARangeOnAnExcelSheet;
        private string _s;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _s = "K1:L2";
            ResultShouldBe(new List<string>()
                           {
                               "K1", "K2", "L1", "L2"
                           });
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _s = "A1:F1";
            ResultShouldBe(new List<string>()
                           {
                               "A1", "B1", "C1", "D1", "E1", "F1"
                           });
        }

        private void ResultShouldBe(List<string> expected)
        {
            _l2194CellsInARangeOnAnExcelSheet.CellsInRange(_s).Should().Equal(expected);
        }
    }
}