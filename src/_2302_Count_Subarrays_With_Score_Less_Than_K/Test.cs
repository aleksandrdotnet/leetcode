namespace _2302_Count_Subarrays_With_Score_Less_Than_K;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 1, 4, 3, 5 }, 10, 6)]
    [InlineData(new[] { 1, 1, 1 }, 5, 5)]
    [InlineData(new[] { 1, 1, 1, 1 }, 20, 10)]
    public void Run(int[] nums, long k, long expected)
    {
        var result = new Solution().CountSubarrays(nums, k);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 2, 1, 4, 3, 5 }, 10, 6)]
    [InlineData(new[] { 1, 1, 1 }, 5, 5)]
    [InlineData(new[] { 1, 1, 1, 1 }, 20, 10)]
    public void Run2(int[] nums, long k, long expected)
    {
        var result = new Solution2().CountSubarrays(nums, k);
        Assert.Equal(expected, result);
    }
}