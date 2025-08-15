namespace _1679_Max_Number_of_K_Sum_Pairs;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, 5, 2)]
    [InlineData(new[] { 3, 1, 3, 4, 3 }, 6, 1)]
    public void Run(int[] nums, int k, int expected)
    {
        var result = new Solution().MaxOperations(nums, k);
        Assert.Equal(expected, result);
    }
}