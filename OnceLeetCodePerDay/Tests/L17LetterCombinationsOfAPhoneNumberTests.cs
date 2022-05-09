using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    public class L17LetterCombinationsOfAPhoneNumberTests
    {
        [SetUp]
        public void SetUp()
        {
            _l17LetterCombinationsOfAPhoneNumber = new L17LetterCombinationsOfAPhoneNumber();
        }

        private L17LetterCombinationsOfAPhoneNumber _l17LetterCombinationsOfAPhoneNumber;
        private string _digits;

        [Test]
        public void Input_23_Should_Return_9_Results()
        {
            _digits = "23";
            ResultShouldBe(new[]
                           {
                               "ad", "ae", "af", "bd", "be", "bf", "cd", "ce",
                               "cf"
                           });
        }

        [Test]
        public void Input_empty_Should_Return_empty()
        {
            _digits = "";
            ResultShouldBe(new string[] { });
        }

        private void ResultShouldBe(string[] expectation)
        {
            _l17LetterCombinationsOfAPhoneNumber.LetterCombinations(_digits).Should()
                                                .BeEquivalentTo(expectation);
        }
    }
}