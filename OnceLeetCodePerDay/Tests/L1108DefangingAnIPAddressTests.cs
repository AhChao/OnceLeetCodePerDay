using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/defanging-an-ip-address/
    public class L1108DefangingAnIPAddressTests
    {
        [Test]
        public void Dots_Of_1111_Should_Be_Replaced()
        {
            var l1108DefangingAnIpAddress = new L1108DefangingAnIPAddress();
            var address = "1.1.1.1";
            Assert.AreEqual(l1108DefangingAnIpAddress.DefangIPaddr(address), "1[.]1[.]1[.]1");
        }
    }
}