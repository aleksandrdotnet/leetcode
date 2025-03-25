namespace _414_Third_Maximum_Number;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 1 }, 1)]
    [InlineData(new[] { 2, 1 }, 2)]
    [InlineData(new[] { 2, 2, 3, 1 }, 1)]
    public void Run(int[] nums, int expected)
    {
        var result = new Solution().ThirdMax(nums);
        Assert.Equal(expected, result);
    }
}