namespace _2359_Find_Closest_Node_to_Given_Two_Nodes;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 2, 3, -1 }, 0, 1, 2)]
    [InlineData(new[] { 1, 2, -1 }, 0, 2, 2)]
    [InlineData(new[] { 4, 4, 8, -1, 9, 8, 4, 4, 1, 1 }, 5, 6, 1)]
    public void Run(int[] edges, int node1, int node2, int expected)
    {
        var result = new Solution().ClosestMeetingNode(edges, node1, node2);
        Assert.Equal(expected, result);
    }
}