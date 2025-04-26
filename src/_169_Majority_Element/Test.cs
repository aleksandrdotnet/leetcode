namespace _169_Majority_Element;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 3 }, 3)]
    [InlineData(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 1 }, 1)]
    public void Run(int[] nums, int expected)
    {
        var result = new Solution().MajorityElement(nums);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 3, 2, 3 }, 3)]
    [InlineData(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    [InlineData(new[] { 1, 1, 1, 2, 2, 2, 3, 3, 1 }, 1)]
    public void Run2(int[] nums, int expected)
    {
        var result = new Solution2().MajorityElement(nums);
        Assert.Equal(expected, result);
    }
}