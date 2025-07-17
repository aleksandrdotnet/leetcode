namespace _151_Reverse_Words_in_a_String;

public class Test
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void Run(string s, string expected)
    {
        var result = new Solution().ReverseWords(s);
        Assert.Equal(expected, result);
    }
}