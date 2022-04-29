using FluentAssertions;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/design-parking-system/
    public class L1603DesignParkingSystemTests
    {
        [SetUp]
        public void SetUp()
        {
            _l1603DesignParkingSystem = new L1603DesignParkingSystem();
        }

        private L1603DesignParkingSystem _l1603DesignParkingSystem;
        private L1603DesignParkingSystem.ParkingSystem _parkingSystem;
        private bool[] _result;

        [Test]
        public void Example1_Result_Should_Be_As_Expected()
        {
            _parkingSystem = new L1603DesignParkingSystem.ParkingSystem(1, 1, 0);
            _result = GetAddCarResult(new[] {1, 2, 3, 1});
            var expected = new[] {true, true, false, false};
            _result.Should().Equal(expected);
        }

        private bool[] GetAddCarResult(int[] parkingOrder)
        {
            var result = new bool[parkingOrder.Length];
            for(int i = 0; i < parkingOrder.Length; i++)
            {
                result[i] = _parkingSystem.AddCar(parkingOrder[i]);
            }

            return result;
        }
    }
}