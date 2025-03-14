namespace _9_Palindrome_Number;

public class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        var res = x.ToString();
        for (int i = 0, j = res.Length - 1; i < res.Length/2; i++, j--)
            if(res[i] != res[j]) return false;
        return true;
    }
    
    public static bool IsPalindromeBest(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reversed = 0;

        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return x == reversed || x == reversed / 10;
    }
}