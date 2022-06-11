using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/replace-all-digits-with-characters/
    public class L1844ReplaceAllDigitsWithCharactersTests
    {
        private L1844ReplaceAllDigitsWithCharacters _l1844ReplaceAllDigitsWithCharacters;
        private string _s;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l1844ReplaceAllDigitsWithCharacters = new L1844ReplaceAllDigitsWithCharacters();
            _s = "a1c1e1";
            ResultShouldBe("abcdef");
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l1844ReplaceAllDigitsWithCharacters = new L1844ReplaceAllDigitsWithCharacters();
            _s = "a1b2c3d4e";
            ResultShouldBe("abbdcfdhe");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1844ReplaceAllDigitsWithCharacters.ReplaceDigits(_s));
        }
    }
}