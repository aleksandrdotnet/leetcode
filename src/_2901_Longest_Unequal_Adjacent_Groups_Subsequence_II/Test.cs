namespace _2901_Longest_Unequal_Adjacent_Groups_Subsequence_II;

public class Test
{
    [Theory]
    [InlineData(new[] { "bab", "dab", "cab" }, new[] { 1, 2, 2 }, new[] { "bab", "dab" })]
    [InlineData(new[] { "a", "b", "c", "d" }, new[] { 1, 2, 3, 4 }, new[] { "a", "b", "c", "d" })]
    [InlineData(new[] { "bdb", "aaa", "ada" }, new[] { 2, 1, 3 }, new[] { "aaa", "ada" })]
    [InlineData(new[] { "baa", "ada" }, new[] { 1, 2 }, new[] { "baa" })]
    [InlineData(new[] { "aaac", "dbede", "cbdeee" }, new[] { 2, 2, 1 }, new[] { "aaac" })]
    [InlineData(new[] { "cda", "bb", "bdc" }, new[] { 3, 1, 1 }, new[] { "cda" })]
    [InlineData(new[] { "aab", "cab", "ba", "dba", "daa", "bca" }, new[] { 4, 3, 4, 6, 4, 3 }, new[] { "aab", "cab" })]
    [InlineData(new[] { "ca", "cb", "bcd", "bb", "ddc" }, new[] { 2, 4, 2, 5, 1 }, new[] { "ca", "cb", "bb" })]
    public void Run(string[] words, int[] groups, IList<string> expected)
    {
        var result = new Solution().GetWordsInLongestSubsequence(words, groups);
        Assert.Equal(expected, result);
    }
}