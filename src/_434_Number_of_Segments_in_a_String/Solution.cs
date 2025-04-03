using System.Text.RegularExpressions;

namespace _434_Number_of_Segments_in_a_String;

public class Solution
{
    public int CountSegments(string s)
    {
        var str = s.Trim();
        var result = 0;

        if (string.IsNullOrEmpty(str))
            return result;

        foreach (var n in str.Split(' '))
        {
            if (n.Length != 0)
                result++;
        }

        return result;
    }

    public int CountSegments2(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        var ans = s.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        return ans.Length;
    }

    public int CountSegments3(string s)
    {
        return Regex.Matches(s, @"[^ ]+").Count;
    }
}