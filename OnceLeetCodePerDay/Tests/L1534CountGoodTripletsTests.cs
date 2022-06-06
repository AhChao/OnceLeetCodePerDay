using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-good-triplets/
    public class L1534CountGoodTripletsTests
    {
        private L1534CountGoodTriplets _l1534CountGoodTriplets;
        private int[] _arr;
        private int _a;
        private int _b;
        private int _c;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _l1534CountGoodTriplets = new L1534CountGoodTriplets();
            _arr = new[] {3, 0, 1, 1, 9, 7};
            _a = 7;
            _b = 2;
            _c = 3;
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _l1534CountGoodTriplets = new L1534CountGoodTriplets();
            _arr = new[] {1, 1, 2, 2, 3};
            _a = 0;
            _b = 0;
            _c = 1;
            ResultShouldBe(0);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1534CountGoodTriplets.CountGoodTriplets(_arr, _a, _b, _c));
        }
    }
}