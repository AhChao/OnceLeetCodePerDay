namespace OnceLeetCodePerDay.Implements;

public class L557ReverseWordsInAStringIII
{
    public string ReverseWords(string s)
    {
        string tempString = "";
        string result = "";
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                result += tempString + ' ';
                tempString = "";
            }
            else if(i == s.Length - 1)
            {
                result += s[i] + tempString;
            }
            else
            {
                tempString = s[i] + tempString;
            }
        }

        return result;
    }
}