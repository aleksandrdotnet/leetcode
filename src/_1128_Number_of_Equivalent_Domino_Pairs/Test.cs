namespace _1128_Number_of_Equivalent_Domino_Pairs;

public class Test
{
    [Fact]
    public void Run()
    {
        var dominoes = new[]
        {
            new[] { 1, 2 },
            new[] { 2, 1 },
            new[] { 3, 4 },
            new[] { 5, 6 }
        };

        var expected = 1;
        var result = new Solution().NumEquivDominoPairs(dominoes);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        var dominoes = new[]
        {
            new[] { 1, 2 },
            new[] { 1, 2 },
            new[] { 1, 1 },
            new[] { 1, 2 },
            new[] { 2, 2 }
        };

        var expected = 3;
        var result = new Solution().NumEquivDominoPairs(dominoes);
        Assert.Equal(expected, result);
    }
}