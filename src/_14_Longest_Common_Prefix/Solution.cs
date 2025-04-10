using System.Text;

namespace _14_Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = new StringBuilder();

        var first = strs.First();
        for (var i = 0; i < first.Length; i++)
        {
            for (var j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length)
                    return result.ToString();

                if (first[i] != strs[j][i])
                    return result.ToString();
            }

            result.Append(first[i]);
        }

        return result.ToString();
    }
}