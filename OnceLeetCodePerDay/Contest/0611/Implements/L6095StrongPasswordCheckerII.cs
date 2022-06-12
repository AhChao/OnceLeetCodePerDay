namespace OnceLeetCodePerDay.Contest._0611.Implements;

public class L6095StrongPasswordCheckerII
{
    public static bool StrongPasswordCheckerII(string password)
    {
        var containLowerCase = false;
        var containUpperCase = false;
        var containDigit = false;
        var containSymbol = false;

        for(var i = 0; i < password.Length; i++)
        {
            var theChar = password[i];
            if(i > 0 && password[i] == password[i - 1])
            {
                return false;
            }

            if(theChar - 'a' >= 0 && theChar - 'a' <= 26)
            {
                containLowerCase = true;
            }

            if(theChar - 'A' >= 0 && theChar - 'A' <= 26)
            {
                containUpperCase = true;
            }

            if(theChar - '0' >= 0 && theChar - '0' <= 10)
            {
                containDigit = true;
            }

            if("!@#$%^&*()-+".Contains(theChar))
            {
                containSymbol = true;
            }
        }

        return password.Length >= 8 &&
               containLowerCase &&
               containUpperCase &&
               containDigit &&
               containSymbol;
    }
}