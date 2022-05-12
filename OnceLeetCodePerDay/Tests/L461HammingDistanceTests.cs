using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/hamming-distance/
    public class L461HammingDistanceTests
    {
        [SetUp]
        public void SetUp()
        {
            _l461HammingDistance = new L461HammingDistance();
        }

        private L461HammingDistance _l461HammingDistance;
        private int _x;
        private int _y;

        [Test]
        public void Input_1_4_Should_Return_2()
        {
            _x = 1;
            _y = 4;
            ResultShouldBe(2);
        }

        [Test]
        public void Input_3_1_Should_Return_2()
        {
            _x = 3;
            _y = 1;
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l461HammingDistance.HammingDistance(_x, _y));
        }
    }
}