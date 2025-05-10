namespace _2918_Minimum_Equal_Sum_of_Two_Arrays_After_Replacing_Zeros;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 0, 1, 0 }, new[] { 6, 5, 0 }, 12)]
    [InlineData(new[] { 2, 0, 2, 0 }, new[] { 1, 4 }, -1)]
    [InlineData(new[] { 1, 2, 3, 2 }, new[] { 1, 4, 3 }, 8)]
    [InlineData(new[] { 0 }, new[] { 0 }, 1)]
    public void Run(int[] nums1, int[] nums2, long expected)
    {
        var result = new Solution().MinSum(nums1, nums2);
        Assert.Equal(expected, result);
    }
}