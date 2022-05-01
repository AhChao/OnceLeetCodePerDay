using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0501.Implement;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/weekly-contest-291/problems/remove-digit-from-number-to-maximize-result/
    //https://leetcode.com/problems/remove-digit-from-number-to-maximize-result/
    public class L6047RemoveDigitFromNumberToMaximizeResultTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6047RemoveDigitFromNumberToMaximizeResult = new L6047RemoveDigitFromNumberToMaximizeResult();
        }

        private L6047RemoveDigitFromNumberToMaximizeResult _l6047RemoveDigitFromNumberToMaximizeResult;
        private string _number;
        private char _digit;

        [Test]
        public void Input_123_3_Should_Return_12()
        {
            _number = "123";
            _digit = '3';
            ResultShouldBe("12");
        }

        [Test]
        public void Input_1231_1_Should_Return_231()
        {
            _number = "1231";
            _digit = '1';
            ResultShouldBe("231");
        }

        [Test]
        public void Input_551_5_Should_Return_51()
        {
            _number = "551";
            _digit = '5';
            ResultShouldBe("51");
        }

        [Test]
        public void Input_133235_3_Should_Return_13325()
        {
            _number = "133235";
            _digit = '3';
            ResultShouldBe("13325");
        }


        [Test]
        public void Input_LongNumber_3_Should_Not_Overflow()
        {
            _number =
                "2998589353917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471";
            _digit = '3';
            ResultShouldBe("299858953917872714814599237991174513476623756395992135212546127959342974628712329595771672911914471");
        }


        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l6047RemoveDigitFromNumberToMaximizeResult.RemoveDigit(_number, _digit));
        }
    }
}