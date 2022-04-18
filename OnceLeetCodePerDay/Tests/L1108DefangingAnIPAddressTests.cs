using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/defanging-an-ip-address/
    public class L1108DefangingAnIPAddressTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1108DefangingAnIpAddress = new L1108DefangingAnIPAddress();
        }

        private L1108DefangingAnIPAddress _l1108DefangingAnIpAddress;
        private string _address;

        [Test]
        public void Dots_Of_1111_Should_Be_Replaced()
        {
            _address = "1.1.1.1";
            DefangResultShouldBe("1[.]1[.]1[.]1");
        }

        [Test]
        public void Dots_Of_2551000500_Should_Be_Replaced()
        {
            _address = "255.100.50.0";
            DefangResultShouldBe("255[.]100[.]50[.]0");
        }

        private void DefangResultShouldBe(string expected)
        {
            Assert.AreEqual(_l1108DefangingAnIpAddress.DefangIPaddr(_address), expected);
        }
    }
}