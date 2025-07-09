namespace _1071_Greatest_Common_Divisor_of_Strings;

public class Test
{
    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData( "ABABAB", "ABAB", "AB")]
    [InlineData( "LEET", "CODE", "")]
    public void Run(string str1, string str2, string expected)
    {
        var result = new Solution().GcdOfStrings(str1, str2);
        Assert.Equal(expected, result);
    }
}