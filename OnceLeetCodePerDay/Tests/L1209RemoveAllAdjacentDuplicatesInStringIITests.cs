using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/
    public class L1209RemoveAllAdjacentDuplicatesInStringIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l1209RemoveAllAdjacentDuplicatesInStringIi = new L1209RemoveAllAdjacentDuplicatesInStringII();
        }

        private L1209RemoveAllAdjacentDuplicatesInStringII _l1209RemoveAllAdjacentDuplicatesInStringIi;
        private string _s;
        private int _k;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _s = "abcd";
            _k = 2;
            ResultShouldBe("abcd");
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _s = "deeedbbcccbdaa";
            _k = 3;
            ResultShouldBe("aa");
        }

        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _s = "pbbcggttciiippooaais";
            _k = 2;
            ResultShouldBe("ps");
        }

        [Test]
        public void Example4_Should_Return_As_Expected()
        {
            _s = "aa";
            _k = 2;
            ResultShouldBe("");
        }

        [Test]
        public void Example5_Should_Return_As_Expected()
        {
            _s = "aabbbb";
            _k = 2;
            ResultShouldBe("");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1209RemoveAllAdjacentDuplicatesInStringIi.RemoveDuplicates(_s, _k));
        }
    }
}