namespace _2131_Longest_Palindrome_by_Concatenating_Two_Letter_Words;

public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        var result = 0;
        var dict = new Dictionary<string, int>();
        var dictSame = new Dictionary<string, int>();

        foreach (var word in words)
        {
            var isSame = word[0] == word[1];

            if (isSame)
            {
                if (dictSame.TryGetValue(word, out var count) && count > 0)
                {
                    dictSame[word]--;
                    result += 4;
                }
                else
                {
                    dictSame[word] = 1;
                }
            }
            else
            {
                var reversedWord = $"{word[1]}{word[0]}";
                if (dict.TryGetValue(reversedWord, out var count) && count > 0)
                {
                    dict[reversedWord]--;
                    result += 4;
                }
                else
                {
                    dict[word] = dict.GetValueOrDefault(word, 0) + 1;
                }
            }
        }

        if (result % 2 == 0) result += dictSame.Values.Any(x => x > 0) ? 2 : 0;

        return result;
    }
}

public class Solution2
{
    public int LongestPalindrome(string[] words)
    {
        var result = 0;
        var freq = new int[26, 26];

        foreach (var word in words)
        {
            var cl = word[0] - 'a';
            var cr = word[1] - 'a';

            if (freq[cr, cl] != 0)
            {
                freq[cr, cl]--;
                result += 4;
            }
            else
            {
                freq[cl, cr]++;
            }
        }

        if (result % 2 == 0)
            for (var i = 0; i < 26; i++)
                if (freq[i, i] != 0)
                    return result + 2;

        return result;
    }
}