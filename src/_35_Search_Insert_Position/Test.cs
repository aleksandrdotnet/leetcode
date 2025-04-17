namespace _35_Search_Insert_Position;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    public void Run(int[] nums, int target, int expected)
    {
        var result = new Solution().SearchInsert(nums, target);
        Assert.Equal(expected, result);
    }
}