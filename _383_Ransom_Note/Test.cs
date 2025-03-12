namespace _383_Ransom_Note;

public class Test
{
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    public void Run(string ransomNote, string magazinem, bool expected)
    {
        var result = Solution.CanConstruct(ransomNote, magazinem);
        Assert.Equal(expected, result);
    }
}