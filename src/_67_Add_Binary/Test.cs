namespace _67_Add_Binary;

public class Test
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void Run(string a, string b, string expected)
    {
        var result = new Solution().AddBinary(a, b);
        Assert.Equal(expected, result);
    }
}