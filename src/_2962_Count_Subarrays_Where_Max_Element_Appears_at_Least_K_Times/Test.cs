namespace _2962_Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 3, 2, 3, 3 }, 2, 6)]
    [InlineData(new[] { 1, 4, 2, 1 }, 3, 0)]
    public void Run(int[] nums, long k, long expected)
    {
        var result = new Solution().CountSubarrays(nums, k);
        Assert.Equal(expected, result);
    }
}