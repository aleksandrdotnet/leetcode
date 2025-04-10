namespace _14_Longest_Common_Prefix;

public class Test
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    [InlineData(new[] { "dog" }, "dog")]
    public void Run(string[] strs, string expected)
    {
        var result = new Solution().LongestCommonPrefix(strs);
        Assert.Equal(expected, result);
    }
}