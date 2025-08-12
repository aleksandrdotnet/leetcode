namespace _334._Increasing_Triplet_Subsequence;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, true)]
    [InlineData(new[] { 5, 4, 3, 2, 1 }, false)]
    [InlineData(new[] { 2, 1, 5, 0, 4, 6 }, true)]
    [InlineData(new[] { 20, 100, 10, 12, 5, 13 }, true)]
    [InlineData(new[] { 1, 5, 0, 4, 1, 3 }, true)]
    [InlineData(new[] { 1, 0, 0, 0, 0, 10, 0, 0, 0, 100000000 }, true)]
    [InlineData(new[] { 5, 1, 5, 5, 2, 5, 4 }, true)]
    [InlineData(new[] { 1, 0, 0, 0, 2, 0, 0, 0, -1, -1, -1, -1, 3 }, true)]
    [InlineData(new[] { 0, 4, 1, -1, 2 }, true)]
    public void Run(int[] nums, bool expected)
    {
        var result = new Solution().IncreasingTriplet(nums);
        Assert.Equal(expected, result);
    }
}