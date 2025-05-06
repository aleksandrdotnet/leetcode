namespace _790_Domino_and_Tromino_Tiling;

public class Test
{
    [Theory]
    [InlineData(1, 1)] // 1
    [InlineData(2, 2)] // 1 // 1
    [InlineData(3, 5)] // 3 // 3
    [InlineData(4, 11)] // 6 // 8
    [InlineData(5, 24)] // 13 // 19
    [InlineData(6, 53)] // 29 // 43
    [InlineData(7, 117)] // 64
    [InlineData(8, 258)] // 141
    [InlineData(30, 312342182)] // 141
    public void Run(int n, int expected)
    {
        var result = new Solution().NumTilings(n);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1)] // 1
    [InlineData(2, 2)] // 1 // 1
    [InlineData(3, 5)] // 3 // 3
    [InlineData(4, 11)] // 6 // 8
    [InlineData(5, 24)] // 13 // 19
    [InlineData(6, 53)] // 29 // 43
    [InlineData(7, 117)] // 64
    [InlineData(8, 258)] // 141
    [InlineData(30, 312342182)] // 141
    public void Run2(int n, int expected)
    {
        var result = new Solution2().NumTilings(n);
        Assert.Equal(expected, result);
    }
}