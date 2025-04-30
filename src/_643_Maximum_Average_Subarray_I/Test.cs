namespace _643_Maximum_Average_Subarray_I;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.750d)]
    [InlineData(new[] { 5 }, 1, 5.00d)]
    public void Run(int[] nums, int k, double expected)
    {
        var result = new Solution().FindMaxAverage(nums, k);
        Assert.Equal(expected, result);
    }
}