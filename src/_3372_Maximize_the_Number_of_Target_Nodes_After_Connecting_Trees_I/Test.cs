namespace _3372_Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_I;

public class Test
{
    [Fact]
    public void Run1()
    {
        int[][] edges1 = [[0, 1], [0, 2], [2, 3], [2, 4]];
        int[][] edges2 = [[0, 1], [0, 2], [0, 3], [2, 7], [1, 4], [4, 5], [4, 6]];
        int[] expected = [9, 7, 9, 8, 8];
        var k = 2;

        var result = new Solution().MaxTargetNodes(edges1, edges2, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        int[][] edges1 = [[0, 1], [0, 2], [0, 3], [0, 4]];
        int[][] edges2 = [[0, 1], [1, 2], [2, 3]];
        int[] expected = [6, 3, 3, 3, 3];
        var k = 1;

        var result = new Solution().MaxTargetNodes(edges1, edges2, k);
        Assert.Equal(expected, result);
    }
}