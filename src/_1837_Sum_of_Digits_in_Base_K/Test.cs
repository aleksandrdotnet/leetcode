namespace _1837_Sum_of_Digits_in_Base_K;

public class Test
{
    [Theory]
    [InlineData(34, 6, 9)]
    [InlineData(10, 10, 1)]
    [InlineData(42, 2, 3)]
    public void Run(int n, int k, int expected)
    {
        var result = new Solution().SumBase(n, k);
        Assert.Equal(expected, result);
    }
}