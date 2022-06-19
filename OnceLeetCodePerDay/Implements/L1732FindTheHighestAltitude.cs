namespace OnceLeetCodePerDay.Implements;

public class L1732FindTheHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        var altitude = 0;
        var maxAltitude = 0;
        for(var i = 0; i < gain.Length; i++)
        {
            altitude += gain[i];
            maxAltitude = maxAltitude > altitude ? maxAltitude : altitude;
        }

        return maxAltitude;
    }
}