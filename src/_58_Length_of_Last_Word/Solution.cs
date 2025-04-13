namespace _58_Length_of_Last_Word;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split(' ').Last().Length;
    }
}