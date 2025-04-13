namespace _58_Length_of_Last_Word;

public class Test
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void Run(string s, int expected)
    {
        var result = new Solution().LengthOfLastWord(s);
        Assert.Equal(expected, result);
    }
}