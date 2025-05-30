namespace _2131_Longest_Palindrome_by_Concatenating_Two_Letter_Words;

public class Test
{
    [Theory]
    [InlineData(new[] { "lc", "cl", "gg" }, 6)]
    [InlineData(new[] { "ab", "ty", "yt", "lc", "cl", "ab" }, 8)]
    [InlineData(new[] { "cc", "ll", "xx" }, 2)]
    [InlineData(new[] { "dd", "aa", "bb", "dd", "aa", "dd", "bb", "dd", "aa", "cc", "bb", "cc", "dd", "cc" }, 22)]
    public void Run(string[] words, int expected)
    {
        var result = new Solution().LongestPalindrome(words);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { "lc", "cl", "gg" }, 6)]
    [InlineData(new[] { "ab", "ty", "yt", "lc", "cl", "ab" }, 8)]
    [InlineData(new[] { "cc", "ll", "xx" }, 2)]
    [InlineData(new[] { "dd", "aa", "bb", "dd", "aa", "dd", "bb", "dd", "aa", "cc", "bb", "cc", "dd", "cc" }, 22)]
    public void Run2(string[] words, int expected)
    {
        var result = new Solution2().LongestPalindrome(words);
        Assert.Equal(expected, result);
    }
}