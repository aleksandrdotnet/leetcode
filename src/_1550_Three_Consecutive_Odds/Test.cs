namespace _1550_Three_Consecutive_Odds;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 6, 4, 1 }, false)]
    [InlineData(new[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, true)]
    public void Run(int[] arr, bool expected)
    {
        var result = new Solution().ThreeConsecutiveOdds(arr);
        Assert.Equal(expected, result);
    }
}