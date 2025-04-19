namespace _2563_Count_the_Number_of_Fair_Pairs;

public class Test
{
    [Theory]
    [InlineData(new[] { 0, 1, 7, 4, 4, 5 }, 3, 6, 6)]
    [InlineData(new[] { 1, 7, 9, 2, 5 }, 11, 11, 1)]
    [InlineData(new[] { 0, 0, 0, 0, 0, 0 }, 0, 0, 15)]
    public void Run(int[] nums, int lower, int upper, long expected)
    {
        var result = new Solution().CountFairPairs(nums, lower, upper);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 0, 1, 7, 4, 4, 5 }, 3, 6, 6)]
    [InlineData(new[] { 1, 7, 9, 2, 5 }, 11, 11, 1)]
    [InlineData(new[] { 0, 0, 0, 0, 0, 0 }, 0, 0, 15)]
    public void Run2(int[] nums, int lower, int upper, long expected)
    {
        var result = new Solution2().CountFairPairs(nums, lower, upper);
        Assert.Equal(expected, result);
    }
}