namespace _941_Valid_Mountain_Array;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 1 }, false)]
    [InlineData(new[] { 3, 5, 5 }, false)]
    [InlineData(new[] { 0, 3, 2, 1 }, true)]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, false)]
    public void Run(int[] input, bool expected)
    {
        var result = new Solution().ValidMountainArray(input);

        Assert.Equal(expected, result);
    }
}