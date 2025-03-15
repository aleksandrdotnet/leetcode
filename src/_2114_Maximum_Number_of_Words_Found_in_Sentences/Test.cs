namespace _2114_Maximum_Number_of_Words_Found_in_Sentences;

public class Test
{
    [Theory]
    [InlineData(new[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }, 6)]
    [InlineData(new[] { "please wait", "continue to fight", "continue to win" }, 3)]
    public void IsPalindrome(string[] input, int expected)
    {
        var result = new Solution().MostWordsFound(input);
        Assert.Equal(expected, result);
    }
}