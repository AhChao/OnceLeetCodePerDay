using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //This repo refer list about https://docs.google.com/spreadsheets/d/1je6J87BX5C5fo5Gbok1TJncVK3-UFkiDznHUzhtHbVU/edit#gid=0
    public class L1710MaximumUnitsOnATruckTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1710MaximumUnitsOnATruck = new L1710MaximumUnitsOnATruck();
        }

        private int[][] _boxTypes;
        private int _truckSize;
        private L1710MaximumUnitsOnATruck _l1710MaximumUnitsOnATruck;

        [Test]
        public void when_truck_size_lower_than_total_box_size()
        {
            _boxTypes = new[] {new[] {1, 3}, new[] {2, 2}, new[] {3, 1},};
            _truckSize = 4;
            MaxItemCanCollectedInTruckSizeShouldBe(8);
        }

        [Test]
        public void Example2_Should_Work_As_Expected()
        {
            _boxTypes = new[] {new[] {5, 10}, new[] {2, 5}, new[] {4, 7}, new[] {3, 9},};
            _truckSize = 10;
            MaxItemCanCollectedInTruckSizeShouldBe(91);
        }

        private void MaxItemCanCollectedInTruckSizeShouldBe(int expected)
        {
            Assert.AreEqual(expected, _l1710MaximumUnitsOnATruck.MaximumUnits(_boxTypes, _truckSize));
        }
    }
}