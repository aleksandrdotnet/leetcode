namespace _125_Valid_Palindrome;

public class Test
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("0P", false)]
    [InlineData("`l;`` 1o1 ??;l`", true)]
    public void Run(string s, bool expected)
    {
        var result = new Solution().IsPalindrome(s);
        Assert.Equal(expected, result);
    }
}