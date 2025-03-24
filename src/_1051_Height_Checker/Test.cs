namespace _1051_Height_Checker;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 1, 4, 2, 1, 3 }, 3)]
    [InlineData(new[] { 5, 1, 2, 3, 4 }, 5)]
    public void Run(int[] heights, int expected)
    {
        var result = new Solution().HeightChecker(heights);
        Assert.Equal(expected, result);
    }
}