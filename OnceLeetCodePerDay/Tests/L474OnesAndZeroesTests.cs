using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/ones-and-zeroes/
    public class L474OnesAndZeroesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l474OnesAndZeroes = new L474OnesAndZeroes();
        }

        private L474OnesAndZeroes _l474OnesAndZeroes;
        private string[] _strs;
        private int _m;
        private int _n;

        [Test]
        public void Example1_Should_Return_4()
        {
            _strs = new[] {"10", "0001", "111001", "1", "0"};
            _m = 5;
            _n = 3;
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_2()
        {
            _strs = new[] {"10", "0", "1"};
            _m = 1;
            _n = 1;
            ResultShouldBe(2);
        }

        [Test]
        public void Example3_Should_Return_3()
        {
            _strs = new[] {"111", "1000", "1000", "1000"};
            _m = 9;
            _n = 3;
            ResultShouldBe(3);
        }

        [Test]
        public void Example4_Should_Return_2()
        {
            _strs = new[] {"1100", "100000", "011111"};
            _m = 6;
            _n = 6;
            ResultShouldBe(2);
        }

        [Test]
        public void Example5_Should_Return_3()
        {
            _strs = new[] {"001", "110", "0000", "0000"};
            _m = 9;
            _n = 2;
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l474OnesAndZeroes.FindMaxForm(_strs, _m, _n));
        }
    }
}