namespace _905_Sort_Array_By_Parity;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 1, 2, 4 }, 2)]
    [InlineData(new[] { 0 }, 0)]
    public void Run(int[] input, int expected)
    {
        var result = new Solution().SortArrayByParity(input);
        for (var i = 0; i < expected; i++) Assert.Equal(0, input[i] % 2);
    }
}