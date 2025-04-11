namespace _1913_Maximum_Product_Difference_Between_Two_Pairs;

public class Test
{
    [Theory]
    [InlineData(new[] { 5, 6, 2, 7, 4 }, 34)]
    [InlineData(new[] { 4, 2, 5, 9, 7, 4, 8 }, 64)]
    public void Run(int[] nums, int expected)
    {
        var result = new Solution().MaxProductDifference(nums);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 5, 6, 2, 7, 4 }, 34)]
    [InlineData(new[] { 4, 2, 5, 9, 7, 4, 8 }, 64)]
    public void Run2(int[] nums, int expected)
    {
        var result = new Solution2().MaxProductDifference(nums);
        Assert.Equal(expected, result);
    }
}