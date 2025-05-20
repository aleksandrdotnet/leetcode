namespace _3024_Type_of_Triangle;

public class Test
{
    [Theory]
    [InlineData()]
    public void Run(int[] nums, string expected)
    {
        var result = new Solution().TriangleType(nums);
        Assert.Equal(expected, result);
    }
}