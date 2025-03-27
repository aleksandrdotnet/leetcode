namespace _977_Squares_of_a_Sorted_Array;

public class Test
{
    [Theory]
    [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    public void Run(int[] nums, int[] expected)
    {
        var result = new Solution().SortedSquares(nums);
        Assert.Equal(expected, result);
    }
}