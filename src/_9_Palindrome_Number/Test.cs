namespace _9_Palindrome_Number;

public class Test
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindromeBest(int input, bool expected)
    {
        var result = Solution.IsPalindromeBest(input);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome(int input, bool expected)
    {
        var result = Solution.IsPalindrome(input);
        Assert.Equal(expected, result);
    }
}