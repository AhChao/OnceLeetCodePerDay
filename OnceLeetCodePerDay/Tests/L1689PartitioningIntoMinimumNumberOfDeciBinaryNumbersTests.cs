using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
    public class L1689PartitioningIntoMinimumNumberOfDeciBinaryNumbersTests
    {
        private L1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers
            _l1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers;

        [Test]
        public void given_32_should_return_3_as_min_count_follow_the_rule()
        {
            _l1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers =
                new L1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers();
            MinCountToNShouldBe(3, "32");
        }

        [Test]
        public void given_82734_should_return_8_as_min_count_follow_the_rule()
        {
            _l1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers =
                new L1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers();
            MinCountToNShouldBe(8, "82734");
        }

        [Test]
        public void given_27346209830709182346_should_return_9_as_min_count_follow_the_rule()
        {
            _l1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers =
                new L1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers();
            MinCountToNShouldBe(9, "27346209830709182346");
        }

        private void MinCountToNShouldBe(int expected, string n)
        {
            Assert.AreEqual(expected, _l1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers.MinPartitions(n));
        }
    }
}