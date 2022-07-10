using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
    public class L1309DecryptStringFromAlphabetToIntegerMappingTests
    {
        private L1309DecryptStringFromAlphabetToIntegerMapping _l1309DecryptStringFromAlphabetToIntegerMapping;
        private string _s;

        [Test]
        public void Example1_Should_Return_As_Expected()
        {
            _l1309DecryptStringFromAlphabetToIntegerMapping = new L1309DecryptStringFromAlphabetToIntegerMapping();
            _s = "10#11#12";
            ResultShouldBe("jkab");
        }

        [Test]
        public void Example2_Should_Return_As_Expected()
        {
            _l1309DecryptStringFromAlphabetToIntegerMapping = new L1309DecryptStringFromAlphabetToIntegerMapping();
            _s = "1326#";
            ResultShouldBe("acz");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l1309DecryptStringFromAlphabetToIntegerMapping.FreqAlphabets(_s));
        }
    }
}