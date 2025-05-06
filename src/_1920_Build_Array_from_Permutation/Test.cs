namespace _1920_Build_Array_from_Permutation;

public class Test
{
    [Theory]
    [InlineData(new[] { 0, 2, 1, 5, 3, 4 }, new[] { 0, 1, 2, 4, 5, 3 })]
    [InlineData(new[] { 5, 0, 1, 2, 3, 4 }, new[] { 4, 5, 0, 1, 2, 3 })]
    public void Run(int[] nums, int[] expected)
    {
        var result = new Solution().BuildArray(nums);
        Assert.Equal(expected, result);
    }
}