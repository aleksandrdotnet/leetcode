namespace _392_Is_Subsequence;

public class Test
{
    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    public void Run(string s, string t, bool expected)
    {
        var result = new Solution().IsSubsequence(s, t);
        Assert.Equal(expected, result);
    }
}