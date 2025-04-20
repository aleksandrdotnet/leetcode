namespace _704_Binary_Search;

public class Test
{
    [Theory]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void Run(int[] nums, int target, int expected)
    {
        var result = new Solution().Search(nums, target);
        Assert.Equal(expected, result);
    }
}