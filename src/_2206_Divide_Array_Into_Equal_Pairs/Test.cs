namespace _2206_Divide_Array_Into_Equal_Pairs;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 3, 2, 2, 2 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    public void CommonFactors(int[] a, bool expected)
    {
        var result = new Solution().DivideArray(a);
        Assert.Equal(expected, result);
    }
}