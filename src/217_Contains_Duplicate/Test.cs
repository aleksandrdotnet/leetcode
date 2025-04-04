namespace _217_Contains_Duplicate;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void Run(int[] nums, bool expected)
    {
        var result = new Solution().ContainsDuplicate(nums);
        Assert.Equal(expected, result);
    }
}