using FluentAssertions;

namespace RunningSumOf1dArray;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
    public void Run(int[] input, int[] output)
    {
        var result = Solution.Run(input);

        output.Should().BeEquivalentTo(result, options => options.WithoutStrictOrdering());
    }
}