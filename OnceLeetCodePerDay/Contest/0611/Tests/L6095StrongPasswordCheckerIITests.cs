using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0611.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-80/problems/strong-password-checker-ii/
    public class L6095StrongPasswordCheckerIITests
    {
        [SetUp]
        public void SetUp()
        {
            _l6095StrongPasswordCheckerIi = new L6095StrongPasswordCheckerII();
        }

        private L6095StrongPasswordCheckerII _l6095StrongPasswordCheckerIi;
        private string _password;

        [Test]
        public void Example1_Should_Be_A_ValidPassword()
        {
            _password = "IloveLe3tcode!";
            ResultShouldBe(true);
        }

        [Test]
        public void Example2_Should_Be_A_NotValidPassword()
        {
            _password = "Me+You--IsMyDream";
            ResultShouldBe(false);
        }

        [Test]
        public void Example3_Should_Be_A_NotValidPassword()
        {
            _password = "1aB!";
            ResultShouldBe(false);
        }

        [Test]
        public void Example4_Should_Be_A_NotValidPassword()
        {
            _password = "a1A!A!A!";
            ResultShouldBe(true);
        }

        [Test]
        public void Example5_Should_Be_A_NotValidPassword()
        {
            _password = "yvTY#@IB#*!hjrQt-TLW&z)$@!%Duqt&ToskxHgnybqpndMI+wP&fcemIk#@KnkMTaUkcIbncpTL";
            ResultShouldBe(false);
        }

        private void ResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, L6095StrongPasswordCheckerII.StrongPasswordCheckerII(_password));
        }
    }
}