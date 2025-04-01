namespace _283_Move_Zeroes;

public class Test
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    public void Run(int[] input, int[] expected)
    {
        new Solution().MoveZeroes(input);
        for (var i = 0; i < input.Length; i++) Assert.Equal(input[i], expected[i]);
    }
}