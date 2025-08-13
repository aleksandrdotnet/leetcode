using System.Text;

namespace _345_Reverse_Vowels_of_a_String;

public class Solution
{
    public string ReverseVowels(string s)
    {
        var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var i = 0;
        var j = s.Length - 1;
        var result = new StringBuilder(s);

        while (i < j)
            if (!vowels.Contains(s[i]))
            {
                i++;
            }
            else if (!vowels.Contains(s[j]))
            {
                j--;
            }
            else
            {
                result.Replace(s[i], s[j], i, 1);
                result.Replace(s[j], s[i], j, 1);
                i++;
                j--;
            }

        return result.ToString();
    }
}