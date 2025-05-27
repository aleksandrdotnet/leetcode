namespace _2894_Divisible_and_Non_divisible_Sums_Difference;

public class Test
{
    [Theory]
    [InlineData(10, 3, 19)]
    [InlineData(5, 6, 15)]
    [InlineData(5, 1, -15)]
    [InlineData(15, 9, 102)]
    public void Run(int n, int m, int expected)
    {
        var result = new Solution().DifferenceOfSums(n, m);
        Assert.Equal(expected, result);
    }
}