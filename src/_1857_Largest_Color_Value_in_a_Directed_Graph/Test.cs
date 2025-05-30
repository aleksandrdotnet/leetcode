namespace _1857_Largest_Color_Value_in_a_Directed_Graph;

public class Test
{
    [Fact]
    public void Run1()
    {
        var expected = 3;
        var colors = "abaca";
        var edges = new int[][] { [0, 1], [0, 2], [2, 3], [3, 4] };

        var result = new Solution().LargestPathValue(colors, edges);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        var expected = -1;
        var colors = "a";
        var edges = new int[][] { [0, 0] };

        var result = new Solution().LargestPathValue(colors, edges);
        Assert.Equal(expected, result);
    }
}