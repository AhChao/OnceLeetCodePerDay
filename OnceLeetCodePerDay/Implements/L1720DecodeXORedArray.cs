namespace OnceLeetCodePerDay.Implements;

public class L1720DecodeXORedArray
{
    public int[] Decode(int[] encoded, int first)
    {
        var result = new int[encoded.Length + 1];
        result[0] = first;
        for(var i = 0; i < encoded.Length; i++)
        {
            result[i + 1] = encoded[i] ! ^ result[i];
        }

        return result;
    }
}