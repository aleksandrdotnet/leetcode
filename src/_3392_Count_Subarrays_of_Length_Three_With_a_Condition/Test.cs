namespace _3392_Count_Subarrays_of_Length_Three_With_a_Condition;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 1, 4, 1 }, 1)]
    [InlineData(new[] { 1, 1, 1 }, 0)]
    public void Run(int[] nums, int expected)
    {
        var result = new Solution().CountSubarrays(nums);
        Assert.Equal(expected, result);
    }
}