using System.Collections.Generic;

namespace OnceLeetCodePerDay.Contest._0528.Implements;

public class BookMyShow
{
    private List<int> _seats;
    private int _seatsPerRow;

    private int _filledRow;


    public BookMyShow(int n, int m)
    {
        _seats = new List<int>();
        _seatsPerRow = m;
        _filledRow = -1;
        for(int i = 0; i < n; i++)
        {
            _seats.Add(_seatsPerRow);
        }
    }

    public int[] Gather(int k, int maxRow)
    {
        for(var i = _filledRow + 1; i <= maxRow; i++)
        {
            var emptySeats = _seats[i];
            if(emptySeats >= k)
            {
                var firstPlace = _seatsPerRow - _seats[i];
                _seats[i] -= k;
                return new[] {i, firstPlace};
            }
        }

        return new int[] { };
    }

    public bool Scatter(int k, int maxRow)
    {
        long totalSeats = 0;
        long maxSeatCount = (long)(maxRow + 1) * (long)_seatsPerRow;
        if(maxSeatCount < k)
        {
            return false;
        }

        for(var i = 0; i <= maxRow; i++)
        {
            var rowRemainSeats = _seats[i];
            totalSeats += rowRemainSeats;
        }


        if(totalSeats >= k)
        {
            for(var i = _filledRow + 1; i <= maxRow; i++)
            {
                var remainSeats = _seats[i];
                if(remainSeats == 0)
                {
                    _filledRow = i;
                    continue;
                }

                if(k - remainSeats >= 0)
                {
                    _seats[i] = 0;
                    k -= remainSeats;
                }
                else
                {
                    _seats[i] -= k;
                    k = 0;
                }

                if(k == 0)
                {
                    break;
                }
            }

            return true;
        }

        return false;
    }
}