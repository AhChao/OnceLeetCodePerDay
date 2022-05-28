using NUnit.Framework;
using OnceLeetCodePerDay.Contest._0528.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/contest/biweekly-contest-79/problems/sender-with-largest-word-count/
    public class L6084SenderWithLargestWordCountTests
    {
        [SetUp]
        public void SetUp()
        {
            _l6084SenderWithLargestWordCount = new L6084SenderWithLargestWordCount();
        }

        private L6084SenderWithLargestWordCount _l6084SenderWithLargestWordCount;
        private string[] _messages;
        private string[] _senders;

        [Test]
        public void Example1_Should_Return_Alice()
        {
            _messages = new[] {"Hello userTwooo", "Hi userThree", "Wonderful day Alice", "Nice day userThree"};
            _senders = new[] {"Alice", "userTwo", "userThree", "Alice"};
            ResultShouldBe("Alice");
        }

        [Test]
        public void Example2_Should_Return_Charlie()
        {
            _messages = new[] {"How is leetcode for everyone", "Leetcode is useful for practice"};
            _senders = new[] {"Bob", "Charlie"};
            ResultShouldBe("Charlie");
        }

        [Test]
        public void Example3_Should_Return_ubIEXAO()
        {
            _messages = new[] {"How is leetcode for everyone", "Leetcode is useful for practice"};
            _senders = new[] {"bob", "Charlie"};
            ResultShouldBe("bob");
        }

        private void ResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, _l6084SenderWithLargestWordCount.LargestWordCount(_messages, _senders));
        }
    }
}