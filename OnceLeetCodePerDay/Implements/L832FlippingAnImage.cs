using System.Linq;

namespace OnceLeetCodePerDay.Implements;

public class L832FlippingAnImage
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        var result = new int[image.Length][];
        for(var i = 0; i < image.Length; i++)
        {
            result[i] = image[i].Reverse().Select(x => x == 1 ? 0 : 1).ToArray();
        }

        return result;
    }
}