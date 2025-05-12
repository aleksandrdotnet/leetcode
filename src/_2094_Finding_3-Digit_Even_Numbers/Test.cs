namespace _2094_Finding_3_Digit_Even_Numbers;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 1, 3, 0 }, new[] { 102, 120, 130, 132, 210, 230, 302, 310, 312, 320 })]
    [InlineData(new[] { 2, 2, 8, 8, 2 }, new[] { 222, 228, 282, 288, 822, 828, 882 })]
    [InlineData(new[] { 3, 7, 5 }, new int[0])]
    public void Run(int[] digits, int[] expected)
    {
        var result = new Solution().FindEvenNumbers(digits);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 2, 1, 3, 0 }, new[] { 102, 120, 130, 132, 210, 230, 302, 310, 312, 320 })]
    [InlineData(new[] { 2, 2, 8, 8, 2 }, new[] { 222, 228, 282, 288, 822, 828, 882 })]
    [InlineData(new[] { 3, 7, 5 }, new int[0])]
    public void Run2(int[] digits, int[] expected)
    {
        var result = new Solution2().FindEvenNumbers(digits);
        Assert.Equal(expected, result);
    }
}