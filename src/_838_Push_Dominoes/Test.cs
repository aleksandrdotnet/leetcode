namespace _838_Push_Dominoes;

public class Test
{
    [Theory]
    [InlineData("RR.L", "RR.L")]
    [InlineData(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    public void Run(string dominoes, string expected)
    {
        var result = new Solution().PushDominoes(dominoes);
        Assert.Equal(expected, result);
    }
}