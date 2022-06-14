namespace OnceLeetCodePerDay.Implements;

public class L2108FindFirstPalindromicStringInTheArray
{
    public string FirstPalindrome(string[] words)
    {
        for(var i = 0; i < words.Length; i++)
        {
            if(CheckIsPalindrome(words[i]))
            {
                return words[i];
            }
        }

        return "";
    }
    
    private bool CheckIsPalindrome(string word)
    {
        var right = word.Length / 2;
        var left = word.Length % 2 == 0 ? word.Length / 2 - 1 : word.Length / 2;
        while(left >= 0)
        {
            if(word[right] != word[left])
            {
                return false;
            }

            right++;
            left--;
        }

        return true;
    }
}