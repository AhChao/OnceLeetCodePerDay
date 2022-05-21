using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/xor-operation-in-an-array/
    public class L1486XOROperationInAnArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1486XorOperationInAnArray = new L1486XOROperationInAnArray();
        }

        private L1486XOROperationInAnArray _l1486XorOperationInAnArray;
        private int _n;
        private int _start;

        [Test]
        public void Input_5_0_Should_Return_8()
        {
            _n = 5;
            _start = 0;
            ResultShouldBe(8);
        }

        [Test]
        public void Input_4_3_Should_Return_8()
        {
            _n = 4;
            _start = 3;
            ResultShouldBe(8);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1486XorOperationInAnArray.XorOperation(_n, _start));
        }
    }
}