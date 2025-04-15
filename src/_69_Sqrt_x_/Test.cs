namespace _69_Sqrt_x_;

public class Test
{
    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(6, 2)]
    [InlineData(0, 0)]
    [InlineData(9, 3)]
    [InlineData(2147395599, 46339)]
    public void Run(int x, int expected)
    {
        var result = new Solution().MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(6, 2)]
    [InlineData(0, 0)]
    [InlineData(9, 3)]
    [InlineData(2147395599, 46339)]
    public void Run2(int x, int expected)
    {
        var result = new Solution2().MySqrt(x);
        Assert.Equal(expected, result);
    }
}