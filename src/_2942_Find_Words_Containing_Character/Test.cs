namespace _2942_Find_Words_Containing_Character;

public class Test
{
    [Theory]
    [InlineData(new[] { "leet", "code" }, 'e', new[] { 0, 1 })]
    [InlineData(new[] { "abc", "bcd", "aaaa", "cbc" }, 'a', new[] { 0, 2 })]
    [InlineData(new[] { "abc", "bcd", "aaaa", "cbc" }, 'z', new int[0])]
    public void Run(string[] words, char x, IList<int> expected)
    {
        var result = new Solution().FindWordsContaining(words, x);
        Assert.Equal(expected, result);
    }
}