namespace _392_Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;

        var left = 0;
        for (var i = 0; i < t.Length; i++)
        {
            if (t[i] == s[left])
                left++;
        }
        
        return left == s.Length;
    }
}