namespace OnceLeetCodePerDay.Implements;

public class L1108DefangingAnIPAddress
{
    public string DefangIPaddr(string address)
    {
        var result = "";
        foreach(var c in address)
        {
            result += (c == '.' ? "[.]" : c);
        }

        return result;
    }
}