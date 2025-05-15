namespace _2900_Longest_Unequal_Adjacent_Groups_Subsequence_I;

public class Test
{
    [Theory]
    [InlineData(new[] { "e", "a", "b" }, new[] { 0, 0, 1 }, new[] { "e", "b" })]
    [InlineData(new[] { "a", "b", "c", "d" }, new[] { 1, 0, 1, 1 }, new[] { "a", "b", "c" })]
    public void Run(string[] words, int[] groups, IList<string> expected)
    {
        var result = new Solution().GetLongestSubsequence(words, groups);
        Assert.Equal(expected, result);
    }
}