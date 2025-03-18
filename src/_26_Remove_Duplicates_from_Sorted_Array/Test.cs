namespace _26_Remove_Duplicates_from_Sorted_Array;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void Run(int[] input, int expected)
    {
        var result = new Solution().RemoveDuplicates(input);
        Assert.Equal(expected, result);
    }
}