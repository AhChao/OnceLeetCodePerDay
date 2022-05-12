namespace OnceLeetCodePerDay.Implements;

public class L461HammingDistance
{
    public int HammingDistance(int x, int y)
    {
        return System.Numerics.BitOperations.PopCount((uint)(x ^ y));
    }
}