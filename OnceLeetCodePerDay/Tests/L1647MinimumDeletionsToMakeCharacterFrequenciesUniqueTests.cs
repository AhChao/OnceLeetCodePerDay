using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
    public class L1647MinimumDeletionsToMakeCharacterFrequenciesUniqueTests
    {
        private L1647MinimumDeletionsToMakeCharacterFrequenciesUnique
            _l1647MinimumDeletionsToMakeCharacterFrequenciesUnique;

        [Test]
        public void Example1_No_Need_To_Delete()
        {
            _l1647MinimumDeletionsToMakeCharacterFrequenciesUnique =
                new L1647MinimumDeletionsToMakeCharacterFrequenciesUnique();
            DeleteTimeShouldBe(0, "aab");
        }

        [Test]
        public void Example2_Need_2_Time_Delete()
        {
            _l1647MinimumDeletionsToMakeCharacterFrequenciesUnique =
                new L1647MinimumDeletionsToMakeCharacterFrequenciesUnique();
            DeleteTimeShouldBe(2, "aaabbbcc");
        }

        [Test]
        public void Example3_Need_2_Time_Delete()
        {
            _l1647MinimumDeletionsToMakeCharacterFrequenciesUnique =
                new L1647MinimumDeletionsToMakeCharacterFrequenciesUnique();
            DeleteTimeShouldBe(2, "ceabaacb");
        }

        private void DeleteTimeShouldBe(int expected, string s)
        {
            Assert.AreEqual(expected, _l1647MinimumDeletionsToMakeCharacterFrequenciesUnique.MinDeletions(s));
        }
    }
}