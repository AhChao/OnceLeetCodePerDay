namespace OnceLeetCodePerDay.Implements;

public class L1603DesignParkingSystem
{
    public class ParkingSystem
    {
        private int[] _carSlots;


        public ParkingSystem(int big, int medium, int small)
        {
            _carSlots = new[]
                        {
                            0, big, medium, small
                        };
        }

        public bool AddCar(int carType)
        {
            if(_carSlots[carType] > 0)
            {
                _carSlots[carType]--;
                return true;
            }

            return false;
        }
    }
}