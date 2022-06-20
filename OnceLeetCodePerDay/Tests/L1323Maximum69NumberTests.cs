using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/maximum-69-number/
    public class L1323Maximum69NumberTests
    {
        private L1323Maximum69Number _l1323Maximum69Number;
        private int _num;

        [Test]
        public void Example1_Should_Return_9669()
        {
            _l1323Maximum69Number = new L1323Maximum69Number();
            _num = 9669;
            ResultShouldBe(9969);
        }

        [Test]
        public void Example2_Should_Return_9999()
        {
            _l1323Maximum69Number = new L1323Maximum69Number();
            _num = 9996;
            ResultShouldBe(9999);
        }

        [Test]
        public void Example3_Should_Return_9999()
        {
            _l1323Maximum69Number = new L1323Maximum69Number();
            _num = 9999;
            ResultShouldBe(9999);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1323Maximum69Number.Maximum69Number(_num));
        }
    }
}