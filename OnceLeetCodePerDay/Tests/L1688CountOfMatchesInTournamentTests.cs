using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/count-of-matches-in-tournament/
    public class L1688CountOfMatchesInTournamentTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1688CountOfMatchesInTournament = new L1688CountOfMatchesInTournament();
        }

        private L1688CountOfMatchesInTournament? _l1688CountOfMatchesInTournament;
        private int _n;

        [Test]
        public void Input_7_Should_Return_6()
        {
            _n = 7;
            ResultShouldBe(6);
        }

        [Test]
        public void Input_14_Should_Return_13()
        {
            _n = 14;
            ResultShouldBe(13);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1688CountOfMatchesInTournament.NumberOfMatches(_n));
        }
    }
}