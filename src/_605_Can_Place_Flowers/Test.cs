namespace _605_Can_Place_Flowers;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 0, 0, 0, 1 }, 1, true)]
    [InlineData(new[] { 1, 0, 0, 0, 1 }, 2, false)]
    [InlineData(new[] { 0, 0, 0 }, 1, true)]
    public void Run(int[] flowerbed, int n, bool expected)
    {
        var result = new Solution().CanPlaceFlowers(flowerbed, n);
        Assert.Equal(expected, result);
    }
}