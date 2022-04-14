using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/jewels-and-stones/
    public class L771JewelsAndStonesTests
    {
        [SetUp]
        public void SetUp()
        {
            _l771JewelsAndStones = new L771JewelsAndStones();
        }

        private L771JewelsAndStones _l771JewelsAndStones;
        private string _jewels;
        private string _stones;

        [Test]
        public void Jewels_Count_Should_Be_3()
        {
            _jewels = "aA";
            _stones = "aAAbbbb";
            NumJewelsInStonesCountShouldBe(3);
        }

        [Test]
        public void Jewels_Count_Should_Be_0()
        {
            _jewels = "z";
            _stones = "ZZ";
            NumJewelsInStonesCountShouldBe(0);
        }

        private void NumJewelsInStonesCountShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l771JewelsAndStones.NumJewelsInStones(_jewels, _stones));
        }
    }
}