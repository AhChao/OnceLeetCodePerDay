using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/network-delay-time/
    public class L743NetworkDelayTimeTests
    {
        [SetUp]
        public void SetUp()
        {
            _l743NetworkDelayTime = new L743NetworkDelayTime();
        }

        private L743NetworkDelayTime _l743NetworkDelayTime;
        private int[][] _times;
        private int _n;
        private int _k;

        [Test]
        public void Example1_Should_Return_2()
        {
            _times = new int[][] {new[] {2, 1, 1}, new[] {2, 3, 1}, new[] {3, 4, 1}};
            _n = 4;
            _k = 2;
            ResultShouldBe(2);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _times = new int[][] {new[] {1, 2, 1}};
            _n = 2;
            _k = 1;
            ResultShouldBe(1);
        }

        [Test]
        public void Example3_Should_Return_n1()
        {
            _times = new int[][] {new[] {1, 2, 1}};
            _n = 2;
            _k = 2;
            ResultShouldBe(-1);
        }

        [Test]
        public void Example4_Should_Return_1()
        {
            _times = new int[][] {new[] {1, 2, 1},new []{2,1,1}};
            _n = 2;
            _k = 2;
            ResultShouldBe(1);
        }

        [Test]
        public void Example5_Should_Return_2()
        {
            _times = new int[][] {new[] {1, 2, 1},new []{2,3,2},new []{1,3,2}};
            _n = 3;
            _k = 1;
            ResultShouldBe(2);
        }
        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l743NetworkDelayTime.NetworkDelayTime(_times, _n, _k));
        }
    }
}