using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/path-with-minimum-effort/
    public class L1631PathWithMinimumEffortTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1631PathWithMinimumEffort = new L1631PathWithMinimumEffort();
        }

        private L1631PathWithMinimumEffort _l1631PathWithMinimumEffort;
        private int[][] _heights;

        [Test]
        public void Example1_Should_Return_2()
        {
            _heights = new int[][] {new[] {1, 2, 2}, new[] {3, 8, 2}, new[] {5, 3, 5}};
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _heights = new int[][] {new[] {1, 2, 3}, new[] {3, 8, 4}, new[] {5, 3, 5}};
            ResultShouldBe(1);
        }

        [Test]
        public void Example3_Should_Return_0()
        {
            _heights = new int[][]
                       {
                           new[] {1, 2, 1, 1, 1}, new[] {1, 2, 1, 2, 1}, new[] {1, 2, 1, 2, 1},
                           new[] {1, 2, 1, 2, 1}, new[] {1, 1, 1, 2, 1}
                       };
            ResultShouldBe(0);
        }

        [Test]
        public void Example4_Should_Return_9()
        {
            _heights = new int[][]
                       {new[] {1, 10, 6, 7, 9, 10, 4, 9}};
            ResultShouldBe(9);
        }

        [Test]
        public void Example5_Should_Return_3()
        {
            _heights = new int[][]
                       {
                           new[] {8, 6, 8, 1, 4, 1}, new[] {10, 3, 1, 8, 9, 10}, new[] {1, 5, 6, 9, 8, 5},
                           new[] {10, 4, 6, 7, 3, 3}, new[] {6, 6, 9, 1, 3, 3}, new[] {3, 1, 10, 3, 4, 1},
                           new[] {6, 1, 6, 10, 7, 10}
                       };
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1631PathWithMinimumEffort.MinimumEffortPath(_heights));
        }
    }
}