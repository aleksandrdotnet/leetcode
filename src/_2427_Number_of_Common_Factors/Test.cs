namespace _2427_Number_of_Common_Factors;

public class Test
{
    [Theory]
    [InlineData(12, 6, 4)]
    [InlineData(25, 30, 2)]
    [InlineData(885, 885, 8)]
    public void CommonFactors(int a, int b, int expected)
    {
        var result = new Solution().CommonFactors(a, b);
        Assert.Equal(expected, result);
    }
}