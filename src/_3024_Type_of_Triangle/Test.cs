namespace _3024_Type_of_Triangle;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 3, 3 }, "equilateral")]
    [InlineData(new[] { 3, 4, 5 }, "scalene")]
    public void Run(int[] nums, string expected)
    {
        var result = new Solution().TriangleType(nums);
        Assert.Equal(expected, result);
    }
}