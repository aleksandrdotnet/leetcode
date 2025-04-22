namespace _125_Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (left <= right)
        {
            if (!IsAlphaNumeric(s[left]))
            {
                left++;
                continue;
            }

            if (!IsAlphaNumeric(s[right]))
            {
                right--;
                continue;
            }

            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                return false;

            left++;
            right--;
        }

        return true;

        bool IsAlphaNumeric(char c)
        {
            return c is >= '0' and <= '9' or >= 'A' and <= 'Z' or >= 'a' and <= 'z';
        }
    }
}