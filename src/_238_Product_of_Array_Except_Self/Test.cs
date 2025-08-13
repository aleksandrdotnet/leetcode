namespace _238_Product_of_Array_Except_Self;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void Run(int[] nums, int[] expected)
    {
        var result = new Solution().ProductExceptSelf(nums);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void Run2(int[] nums, int[] expected)
    {
        var result = new Solution2().ProductExceptSelf(nums);
        Assert.Equal(expected, result);
    }
}