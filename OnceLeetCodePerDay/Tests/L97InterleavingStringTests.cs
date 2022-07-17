using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/interleaving-string/
    public class L97InterleavingStringTests
    {
        private L97InterleavingString _l97InterleavingString;
        private string _s1;
        private string _s2;
        private string _s3;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l97InterleavingString = new L97InterleavingString();
            _s1 = "aabcc";
            _s2 = "dbbca";
            _s3 = "aadbbcbcac";
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l97InterleavingString = new L97InterleavingString();
            _s1 = "aabcc";
            _s2 = "dbbca";
            _s3 = "aadbbbaccc";
            ResultShouldBe(false);
        }


        [Test]
        public void Example3_Should_Return_As_Expected()
        {
            _l97InterleavingString = new L97InterleavingString();
            _s1 = "";
            _s2 = "";
            _s3 = "";
            ResultShouldBe(true);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _l97InterleavingString.IsInterleave(_s1, _s2, _s3));
        }
    }
}