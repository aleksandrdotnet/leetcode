namespace _219_Contains_Duplicate_II;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void Run(int[] nums, int k, bool expected)
    {
        var result = new Solution().ContainsNearbyDuplicate(nums, k);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void Run2(int[] nums, int k, bool expected)
    {
        var result = new Solution2().ContainsNearbyDuplicate(nums, k);
        Assert.Equal(expected, result);
    }
}