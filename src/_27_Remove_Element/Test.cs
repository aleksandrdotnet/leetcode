namespace _27_Remove_Element;

public class Test
{
    [Theory]
    [InlineData(new[] { 3,2,2,3 }, 3, 2)]
    [InlineData(new[] { 0,1,2,2,3,0,4,2 }, 2, 5)]
    public void Run(int[] input, int val, int expected)
    {
        var result = new Solution().RemoveElement(input, val);
        for (var i = 0; i < result; i++)
            Assert.True(input[i] != val);
        
        Assert.Equal(expected, result);
    }
}