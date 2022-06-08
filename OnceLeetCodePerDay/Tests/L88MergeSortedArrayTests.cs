using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //This repo refer list about https://docs.google.com/spreadsheets/d/1je6J87BX5C5fo5Gbok1TJncVK3-UFkiDznHUzhtHbVU/edit#gid=0
    public class L88MergeSortedArrayTests
    {
        [SetUp]
        public void SetUp()
        {
            _l88MergeSortedArray = new L88MergeSortedArray();
        }

        private L88MergeSortedArray _l88MergeSortedArray;
        private int[] _nums1;
        private int _m;
        private int[] _nums2;
        private int _n;

        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            _nums1 = new[] {1, 2, 3, 0, 0, 0};
            _m = 3;
            _nums2 = new[] {2, 5, 6};
            _n = 3;
            CheckTheResult(new[] {1, 2, 2, 3, 5, 6});
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _nums1 = new[] {1};
            _m = 1;
            _nums2 = new int[] { };
            _n = 0;
            CheckTheResult(new[] {1});
        }

        [Test]
        public void Example3_Should_Work_As_Expected()
        {
            _nums1 = new[] {0};
            _m = 0;
            _nums2 = new int[] {1};
            _n = 1;
            CheckTheResult(new[] {1});
        }

        private void CheckTheResult(int[] expectation)
        {
            _l88MergeSortedArray.Merge(_nums1, _m, _nums2, _n);
            _nums1.Should().BeEquivalentTo(expectation);
        }
    }
}