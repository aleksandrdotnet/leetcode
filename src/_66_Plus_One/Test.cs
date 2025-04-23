namespace _66_Plus_One;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [InlineData(new[] { 9 }, new[] { 1, 0 })]
    [InlineData(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
    public void Run2(int[] digits, int[] expected)
    {
        var result = new Solution2().PlusOne(digits);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [InlineData(new[] { 9 }, new[] { 1, 0 })]
    public void Run(int[] digits, int[] expected)
    {
        var result = new Solution().PlusOne(digits);
        Assert.Equal(expected, result);
    }
}