using System.Text;

namespace _151_Reverse_Words_in_a_String;

public class Solution
{
    public string ReverseWords(string s)
    {
        var result = new StringBuilder();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
                continue;

            var j = i;
            while (j > 0 && s[j - 1] != ' ')
            {
                j--;
            }

            result.Append(s[j..(i + 1)]);

            var lastSpace = false;
            var k = j - 1;
            while (k >= 0)
            {
                if (s[k] != ' ')
                {
                    lastSpace = true;
                    break;
                }

                k--;
            }

            if (lastSpace)
                result.Append(' ');

            i = j;
        }

        return result.ToString();
    }
}