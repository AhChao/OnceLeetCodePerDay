namespace OnceLeetCodePerDay.Implements;

public class L1662CheckIfTwoStringArraysAreEquivalent
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        return string.Join("", word1) == string.Join("", word2);
    }
}