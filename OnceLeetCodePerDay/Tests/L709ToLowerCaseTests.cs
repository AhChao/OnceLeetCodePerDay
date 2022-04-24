using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/to-lower-case/
    public class L709ToLowerCaseTests
    {
        [SetUp]
        public void SetUp()
        {
            _l709ToLowerCase = new L709ToLowerCase();
        }

        private L709ToLowerCase _l709ToLowerCase;
        private string _input;

        [Test]
        public void Input_Hello_Should_Return_hello()
        {
            _input = "Hello";
            Result_Should_Be("hello");
        }

        [Test]
        public void Input_here_Should_Return_here()
        {
            _input = "here";
            Result_Should_Be("here");
        }


        [Test]
        public void Input_LOVELY_Should_Return_lovely()
        {
            _input = "LOVELY";
            Result_Should_Be("lovely");
        }


        private void Result_Should_Be(string expected)
        {
            Assert.AreEqual(expected, _l709ToLowerCase.ToLowerCase(_input));
        }
    }
}