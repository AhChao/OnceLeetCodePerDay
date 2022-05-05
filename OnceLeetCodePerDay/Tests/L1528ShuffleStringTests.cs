using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/shuffle-string/
    public class L1528ShuffleStringTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1528ShuffleString = new L1528ShuffleString();
        }

        private L1528ShuffleString _l1528ShuffleString;
        private string _s;
        private int[] _indices;

        [Test]
        public void Example1_Should_Return_leetcode()
        {
            _s = "codeleet";
            _indices = new[] {4, 5, 6, 7, 0, 2, 1, 3};
            ResultShouldBe("leetcode");
        }

        [Test]
        public void Example2_Should_Return_abc()
        {
            _s = "abc";
            _indices = new[] {0, 1, 2};
            ResultShouldBe("abc");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1528ShuffleString.RestoreString(_s, _indices));
        }
    }
}