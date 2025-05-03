namespace _1007_Minimum_Domino_Rotations_For_Equal_Row;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 1, 2, 4, 2, 2 }, new[] { 5, 2, 6, 2, 3, 2 }, 2)]
    [InlineData(new[] { 3, 5, 1, 2, 3 }, new[] { 3, 6, 3, 3, 4 }, -1)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    public void Run(int[] tops, int[] bottoms, int expected)
    {
        var result = new Solution().MinDominoRotations(tops, bottoms);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 2, 1, 2, 4, 2, 2 }, new[] { 5, 2, 6, 2, 3, 2 }, 2)]
    [InlineData(new[] { 3, 5, 1, 2, 3 }, new[] { 3, 6, 3, 3, 4 }, -1)]
    [InlineData(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
    public void Run2(int[] tops, int[] bottoms, int expected)
    {
        var result = new Solution2().MinDominoRotations(tops, bottoms);
        Assert.Equal(expected, result);
    }
}