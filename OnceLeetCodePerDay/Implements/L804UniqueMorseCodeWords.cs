using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class L804UniqueMorseCodeWords
{
    private string[] _mosTable = new[]
                                 {
                                     ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-",
                                     ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-",
                                     ".--", "-..-", "-.--", "--.."
                                 };

    public int UniqueMorseRepresentations(string[] words)
    {
        var mosArr = new string[words.Length];
        for(var i = 0; i < words.Length; i++)
        {
            mosArr[i] = ParseToMos(words[i]);
        }

        return new HashSet<string>(mosArr).Count;
    }

    private string ParseToMos(string word)
    {
        var result = "";
        for(var i = 0; i < word.Length; i++)
        {
            result += _mosTable[word[i] - 'a'];
        }

        return result;
    }
}