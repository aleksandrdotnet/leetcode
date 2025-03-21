using FluentAssertions;

namespace _1299_Replace_Elements_with_Greatest_Element_on_Right_Side;

public class Test
{
    [Theory]
    [InlineData(new[] { 17, 18, 5, 4, 6, 1 }, new[] { 18, 6, 6, 6, 1, -1 })]
    [InlineData(new[] { 400 }, new[] { -1 })]
    public void Run(int[] input, int[] expected)
    {
        var result = new Solution().ReplaceElements(input);

        result.Should().BeEquivalentTo(expected);
    }
}