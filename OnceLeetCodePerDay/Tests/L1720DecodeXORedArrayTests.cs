using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/decode-xored-array/
    public class L1720DecodeXORedArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1720DecodeXoRedArray = new L1720DecodeXORedArray();
        }

        private L1720DecodeXORedArray _l1720DecodeXoRedArray;
        private int[] _encoded;
        private int _first;

        [Test]
        public void Input_123_1_Should_Return_1021()
        {
            _encoded = new[] {1, 2, 3};
            _first = 1;
            ResultShouldBe(new[] {1, 0, 2, 1});
        }

        [Test]
        public void Input_6273_4_Should_Return_42074()
        {
            _encoded = new[] {6, 2, 7, 3};
            _first = 4;
            ResultShouldBe(new[] {4, 2, 0, 7, 4});
        }

        private void ResultShouldBe(int[] expectation)
        {
            _l1720DecodeXoRedArray.Decode(_encoded, _first).Should().Equal(expectation);
        }
    }
}