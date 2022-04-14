namespace OnceLeetCodePerDay.Implements;

public class L771JewelsAndStones
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var jewelCount = 0;
        var jewelMapping = new bool[58];
        foreach(var jewel in jewels)
        {
            jewelMapping[jewel - 'A'] = true;
        }

        foreach(var stone in stones)
        {
            if(jewelMapping[stone - 'A']) jewelCount++;
        }

        return jewelCount;
    }
}