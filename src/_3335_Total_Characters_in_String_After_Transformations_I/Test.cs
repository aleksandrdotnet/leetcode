namespace _3335_Total_Characters_in_String_After_Transformations_I;

public class Test
{
    [Theory]
    [InlineData("abcyy", 2, 7)]
    [InlineData("azbk", 1, 5)]
    public void Run(string s, int t, int expected)
    {
        var result = new Solution().LengthAfterTransformations(s, t);
        Assert.Equal(expected, result);
    }
}