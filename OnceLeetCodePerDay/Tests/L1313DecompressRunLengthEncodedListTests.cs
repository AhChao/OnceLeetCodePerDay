using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/decompress-run-length-encoded-list/
    public class L1313DecompressRunLengthEncodedListTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1313DecompressRunLengthEncodedList = new L1313DecompressRunLengthEncodedList();
        }

        private L1313DecompressRunLengthEncodedList _l1313DecompressRunLengthEncodedList;
        private int[] _nums;

        [Test]
        public void Input_1234_Should_Return_2444()
        {
            _nums = new[] {1, 2, 3, 4};
            ResultShouldBe(new[] {2, 4, 4, 4});
        }

        [Test]
        public void Input_1123_Should_Return_133()
        {
            _nums = new[] {1, 1, 2, 3};
            ResultShouldBe(new[] {1, 3, 3});
        }

        private void ResultShouldBe(int[] expected)
        {
            _l1313DecompressRunLengthEncodedList.DecompressRLElist(_nums).Should().Equal(expected);
        }
    }
}