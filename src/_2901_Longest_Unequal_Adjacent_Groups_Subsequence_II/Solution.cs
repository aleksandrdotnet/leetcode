namespace _2901_Longest_Unequal_Adjacent_Groups_Subsequence_II;

public class Solution
{
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
    {
        int n = words.Length;
        int[] dp = new int[n]; // dp[i] — длина максимальной подпоследовательности, заканчивающейся на i
        int[] prev = new int[n]; // для восстановления пути
        Array.Fill(dp, 1);
        Array.Fill(prev, -1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (groups[j] != groups[i] && words[j].Length == words[i].Length && Hamming(words[j], words[i]) == 1)
                {
                    if (dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
            }
        }

        // найти индекс конца максимальной подпоследовательности
        int maxLen = 0, last = 0;
        for (int i = 0; i < n; i++)
        {
            if (dp[i] > maxLen)
            {
                maxLen = dp[i];
                last = i;
            }
        }

        // восстановить путь
        var res = new List<string>();
        while (last != -1)
        {
            res.Add(words[last]);
            last = prev[last];
        }

        res.Reverse();
        return res;
    }

    private int Hamming(string a, string b)
    {
        int diff = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) diff++;
        }

        return diff;
    }
}