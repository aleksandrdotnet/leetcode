namespace _1827_Minimum_Operations_to_Make_the_Array_Increasing;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 1, 1 }, 3)]
    [InlineData(new[] { 1, 5, 2, 4, 1 }, 14)]
    [InlineData(new[] { 8 }, 0)]
    public void Run(int[] nums, int expected)
    {
        var result = new Solution().MinOperations(nums);
        Assert.Equal(expected, result);
    }
}