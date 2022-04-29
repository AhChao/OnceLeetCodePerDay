namespace OnceLeetCodePerDay;

public class L344ReverseString
{
    public void ReverseString(char[] chars)
    {
        var left = 0;
        var right = chars.Length - 1;
        while(left < right)
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);
            left++;
            right--;
        }
    }
}