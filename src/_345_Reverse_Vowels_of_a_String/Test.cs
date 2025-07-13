namespace _345_Reverse_Vowels_of_a_String;

public class Test
{
    [Theory]
    [InlineData("IceCreAm", "AceCreIm")]
    [InlineData("leetcode", "leotcede")]
    public void Run(string s, string expected)
    {
        var result = new Solution().ReverseVowels(s);
        Assert.Equal(expected, result);
    }
}