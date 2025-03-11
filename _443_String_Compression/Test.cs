namespace _443_String_Compression;

public class Test
{
    [Theory]
    [InlineData(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6, new[] { 'a', '2', 'b', '2', 'c', '3' })]
    [InlineData(new[] { 'a' }, 1, new[] { 'a' })]
    [InlineData(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }, 4,
        new[] { 'a', 'b', '1', '2' })]
    public void Run(char[] input, int output, char[] expected)
    {
        var result = Solution.Run(input);

        Assert.Equal(output, result);
        for (var i = 0; i < output; i++) Assert.Equal(input[i], expected[i]);
    }
}