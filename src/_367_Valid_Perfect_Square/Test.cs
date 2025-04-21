namespace _367_Valid_Perfect_Square;

public class Test
{
    [Theory]
    [InlineData(16, true)]
    [InlineData(14, false)]
    [InlineData(1, true)]
    [InlineData(9, true)]
    public void Run(int num, bool expected)
    {
        var result = new Solution().IsPerfectSquare(num);
        Assert.Equal(expected, result);
    }
}