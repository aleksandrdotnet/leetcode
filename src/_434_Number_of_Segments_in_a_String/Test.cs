namespace _434_Number_of_Segments_in_a_String;

public class Test
{
    [Theory]
    [InlineData("Hello, my name is John", 5)]
    [InlineData("Hello", 1)]
    [InlineData("             ", 0)]
    public void Run(string s, int expected)
    {
        var result = new Solution().CountSegments(s);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Hello, my name is John", 5)]
    [InlineData("Hello", 1)]
    [InlineData("             ", 0)]
    public void Run2(string s, int expected)
    {
        var result = new Solution().CountSegments2(s);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Hello, my name is John", 5)]
    [InlineData("Hello", 1)]
    [InlineData("             ", 0)]
    public void Run3(string s, int expected)
    {
        var result = new Solution().CountSegments3(s);
        Assert.Equal(expected, result);
    }
}