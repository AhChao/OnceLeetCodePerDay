namespace OnceLeetCodePerDay.Implements;

public class L942DIStringMatch
{
    public int[] DiStringMatch(string s)
    {
        var list = new int[s.Length + 1];
        var left = 0;
        var right = s.Length;
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == 'I')
            {
                list[i] = left;
                left++;
            }
            else
            {
                list[i] = right;
                right--;
            }
        }

        list[s.Length] = left;

        return list;
    }
}