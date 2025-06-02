namespace _135_Candy;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 0, 2 }, 5)]
    [InlineData(new[] { 1, 2, 2 }, 4)]
    [InlineData(new[] { 1, 3, 2, 2, 1 }, 7)]
    public void Run(int[] ratings, int expected)
    {
        var result = new Solution().Candy(ratings);
        Assert.Equal(expected, result);
    }
}