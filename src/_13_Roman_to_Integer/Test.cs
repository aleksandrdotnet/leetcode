namespace _13_Roman_to_Integer;

public class Test
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Run(string s, int expected)
    {
        var result = new Solution().RomanToInt(s);
        Assert.Equal(expected, result);
    }
}