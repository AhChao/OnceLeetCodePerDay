using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0528.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-79/problems/maximum-total-importance-of-roads/
    public class L6085MaximumTotalImportanceOfRoadsTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6085MaximumTotalImportanceOfRoads = new L6085MaximumTotalImportanceOfRoads();
        }

        private L6085MaximumTotalImportanceOfRoads _l6085MaximumTotalImportanceOfRoads;
        private int[][] _roads;
        private int _n;

        [Test]
        public void Example1_Should_Return_43()
        {
            _roads = new int[][]
                     {
                         new[] {0, 1}, new[] {1, 2}, new[] {2, 3}, new[] {0, 2}, new[] {1, 3},
                         new[] {2, 4},
                     };
            _n = 5;
            ResultShouldBe(43);
        }

        [Test]
        public void Example2_Should_Return_20()
        {
            _roads = new int[][]
                     {
                         new[] {0, 3}, new[] {2, 4}, new[] {1, 3}
                     };
            _n = 5;
            ResultShouldBe(20);
        }

        [Test]
        public void Example3_Should_Return_9()
        {
            _roads = new int[][]
                     {
                         new[] {0, 1}
                     };
            _n = 5;
            ResultShouldBe(9);
        }
        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l6085MaximumTotalImportanceOfRoads.MaximumImportance(_n, _roads));
        }
    }
}