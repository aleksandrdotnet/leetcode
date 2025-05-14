namespace _3337_Total_Characters_in_String_After_Transformations_II;

public class Test
{
    [Theory]
    [InlineData("abcyy", 2, new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 }, 7)]
    [InlineData("azbk", 1, new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 8)]
    [InlineData("x", 16, new[] { 6, 6, 8, 1, 9, 9, 10, 3, 9, 4, 8, 5, 2, 8, 10, 2, 6, 8, 2, 3, 3, 7, 2, 6, 4, 2 }, 417796858)]
    public void Run(string s, int t, IList<int> nums, int expected)
    {
        var result = new Solution().LengthAfterTransformations(s, t, nums);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("abcyy", 2, new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 }, 7)]
    [InlineData("azbk", 1, new[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 8)]
    [InlineData("x", 16, new[] { 6, 6, 8, 1, 9, 9, 10, 3, 9, 4, 8, 5, 2, 8, 10, 2, 6, 8, 2, 3, 3, 7, 2, 6, 4, 2 }, 417796858)]
    public void Run2(string s, int t, IList<int> nums, int expected)
    {
        var result = new Solution2().LengthAfterTransformations(s, t, nums);
        Assert.Equal(expected, result);
    }
}