namespace _3467_Transform_Array_by_Parity;

public class Test
{
    [Theory]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 0, 0, 1, 1 })]
    [InlineData(new[] { 1, 5, 1, 4, 2 }, new[] { 0, 0, 1, 1, 1 })]
    public void Run(int[] nums, int[] expected)
    {
        var result = new Solution().TransformArray(nums);
        Assert.Equal(expected, result);
    }
}