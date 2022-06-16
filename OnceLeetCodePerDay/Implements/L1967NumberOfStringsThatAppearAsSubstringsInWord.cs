namespace OnceLeetCodePerDay.Implements;

public class L1967NumberOfStringsThatAppearAsSubstringsInWord
{
    public int NumOfStrings(string[] patterns, string word)
    {
        var result = 0;
        for(var i = 0; i < patterns.Length; i++)
        {
            var findResult = word.IndexOf(patterns[i]);
            if(findResult != -1)
            {
                result += 1;
            }
        }

        return result;
    }
}