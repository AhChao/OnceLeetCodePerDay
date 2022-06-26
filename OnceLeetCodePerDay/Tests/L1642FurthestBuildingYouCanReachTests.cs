using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/furthest-building-you-can-reach/
    public class L1642FurthestBuildingYouCanReachTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1642FurthestBuildingYouCanReach = new L1642FurthestBuildingYouCanReach();
        }

        private L1642FurthestBuildingYouCanReach _l1642FurthestBuildingYouCanReach;
        private int[] _heights;
        private int _bricks;
        private int _ladders;

        [Test]
        public void Example1_Should_Return_4()
        {
            _heights = new[] {4, 2, 7, 6, 9, 14, 12};
            _bricks = 5;
            _ladders = 1;
            ResultShouldBe(4);
        }

        [Test]
        public void Example2_Should_Return_7()
        {
            _heights = new[] {4, 12, 2, 7, 3, 18, 20, 3, 19};
            _bricks = 10;
            _ladders = 2;
            ResultShouldBe(7);
        }

        [Test]
        public void Example3_Should_Return_3()
        {
            _heights = new[] {14, 3, 19, 3};
            _bricks = 17;
            _ladders = 0;
            ResultShouldBe(3);
        }

        private void ResultShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1642FurthestBuildingYouCanReach.FurthestBuilding(_heights, _bricks, _ladders));
        }
    }
}