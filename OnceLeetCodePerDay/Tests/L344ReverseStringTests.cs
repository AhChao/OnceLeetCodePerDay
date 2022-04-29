using NUnit.Framework;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/reverse-string/
    public class L344ReverseStringTests
    {
        [SetUp]
        public void SetUp()
        {
            _l344ReverseString = new L344ReverseString();
        }

        private L344ReverseString _l344ReverseString;
        private char[] _s;

        [Test]
        public void Input_hello_Result_Should_Be_olleh()
        {
            _s = new[] {'h', 'e', 'l', 'l', 'o'};
            ResultShouldBe(new[]
                           {
                               'o', 'l', 'l', 'e', 'h'
                           });
        }

        [Test]
        public void Input_Hannah_Result_Should_Be_hannaH()
        {
            _s = new[] {'H', 'a', 'n', 'n', 'a', 'h'};
            ResultShouldBe(new[]
                           {
                               'h', 'a', 'n', 'n', 'a', 'H'
                           });
        }

        private void ResultShouldBe(char[] expected)
        {
            _l344ReverseString.ReverseString(_s);
            Assert.AreEqual(expected, _s);
        }
    }
}