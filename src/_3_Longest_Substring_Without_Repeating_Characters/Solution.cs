namespace _3_Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if(s.Length <= 1)
            return s.Length;
        
        var left = 0;
        var max = 0;
        
        var dict = new Dictionary<char, int>();
        for (var right = 0; right < s.Length; right++)
        {
            if (dict.TryGetValue(s[right], out var index))
            {
                left = Math.Max(left, index + 1);
            }
            
            dict[s[right]] = right;
            
            max = Math.Max(max, right - left + 1);
        }
        
        return max;
    }
}