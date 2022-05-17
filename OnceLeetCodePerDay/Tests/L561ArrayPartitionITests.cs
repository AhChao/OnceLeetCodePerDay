using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/array-partition-i/
    public class L561ArrayPartitionITests
    {
        [SetUp]
        public void SetUp()
        {
            _l561ArrayPartitionI = new L561ArrayPartitionI();
        }

        private L561ArrayPartitionI _l561ArrayPartitionI;
        private int[] _nums;

        [Test]
        public void Input_1432_Should_Return_4()
        {
            _nums = new[] {1, 4, 3, 2};
            ResultShouldBe(4);
        }

        [Test]
        public void Input_626512_Should_Return_9()
        {
            _nums = new[] {6, 2, 6, 5, 1, 2};
            ResultShouldBe(9);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l561ArrayPartitionI.ArrayPairSum(_nums));
        }
    }
}