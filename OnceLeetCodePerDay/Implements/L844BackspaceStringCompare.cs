namespace OnceLeetCodePerDay.Implements;

public class L844BackspaceStringCompare
{
    public bool BackspaceCompare(string s, string t)
    {
        var newS = "";
        var newT = "";
        foreach(var c in s)
        {
            if(c == '#')
            {
                newS = newS.Length > 0 ? newS.Substring(0, newS.Length - 1) : newS;
            }
            else
            {
                newS += c;
            }
        }

        foreach(var c in t)
        {
            if(c == '#')
            {
                newT = newT.Length > 0 ? newT.Substring(0, newT.Length - 1) : newT;
            }
            else
            {
                newT += c;
            }
        }

        return newS == newT;
    }
}