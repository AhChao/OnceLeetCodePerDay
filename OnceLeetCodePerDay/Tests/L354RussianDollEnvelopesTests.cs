using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/russian-doll-envelopes/
    public class L354RussianDollEnvelopesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l354RussianDollEnvelopes = new L354RussianDollEnvelopes();
        }

        private L354RussianDollEnvelopes _l354RussianDollEnvelopes;
        private int[][] _envelopes;

        [Test]
        public void Example1_Should_Return_3()
        {
            _envelopes = new int[][] {new[] {5, 4}, new[] {6, 4}, new[] {6, 7}, new[] {2, 3}};
            ResultShouldBe(3);
        }

        [Test]
        public void Example2_Should_Return_1()
        {
            _envelopes = new int[][] {new[] {1, 1}, new[] {1, 1}, new[] {1, 1}};
            ResultShouldBe(1);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l354RussianDollEnvelopes.MaxEnvelopes(_envelopes));
        }
    }
}