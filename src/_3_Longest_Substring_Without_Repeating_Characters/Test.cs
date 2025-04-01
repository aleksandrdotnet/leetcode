namespace _3_Longest_Substring_Without_Repeating_Characters;

public class Test
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void Run(string s, int expected)
    {
        var result = new Solution().LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}