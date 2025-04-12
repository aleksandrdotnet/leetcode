namespace _20_Valid_Parentheses;

public class Test
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([])", true)]
    [InlineData("(", false)]
    [InlineData("]", false)]
    public void Run(string s, bool expected)
    {
        var result = new Solution().IsValid(s);
        Assert.Equal(expected, result);
    }
}