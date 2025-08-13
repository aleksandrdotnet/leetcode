namespace _11_Container_With_Most_Water;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    public void Run(int[] height, int expected)
    {
        var result = new Solution().MaxArea(height);
        Assert.Equal(expected, result);
    }
}