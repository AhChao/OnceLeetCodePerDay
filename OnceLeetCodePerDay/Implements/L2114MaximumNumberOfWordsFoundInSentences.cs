namespace OnceLeetCodePerDay.Implements;

public class L2114MaximumNumberOfWordsFoundInSentences
{
    public int MostWordsFound(string[] sentences)
    {
        var maxWordsCount = 0;
        foreach(var sentence in sentences)
        {
            var wordCount = sentence.Split(' ').Length;
            if(wordCount > maxWordsCount) maxWordsCount = wordCount;
        }

        return maxWordsCount;
    }
}