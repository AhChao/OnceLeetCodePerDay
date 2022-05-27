using System;
using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L2037MinimumNumberOfMovesToSeatEveryone
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        var orderedSeats = seats.OrderBy(x => x).ToList();
        return students.OrderBy(x => x).ToList().Select((x, i) => Math.Abs(x - orderedSeats[i])).Sum();
    }
}