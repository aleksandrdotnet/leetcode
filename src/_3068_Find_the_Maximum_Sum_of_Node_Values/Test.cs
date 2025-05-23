namespace _3068_Find_the_Maximum_Sum_of_Node_Values;

public class Test
{
    [Fact]
    public void Run1()
    {
        var k = 3;
        int[] nums = [1, 2, 1];
        int[][] edges = [[0, 1], [0, 2]];
        var expected = 6;
        var result = new Solution().MaximumValueSum(nums, k, edges);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        var k = 7;
        int[] nums = [2, 3];
        int[][] edges = [[0, 1]];
        var expected = 9;
        var result = new Solution().MaximumValueSum(nums, k, edges);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run3()
    {
        var k = 3;
        int[] nums = [7, 7, 7, 7, 7, 7];
        int[][] edges = [[0, 1], [0, 2], [0, 3], [0, 4], [0, 5]];
        var expected = 42;
        var result = new Solution().MaximumValueSum(nums, k, edges);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run21()
    {
        var k = 3;
        int[] nums = [1, 2, 1];
        int[][] edges = [[0, 1], [0, 2]];
        var expected = 6;
        var result = new Solution2().MaximumValueSum(nums, k, edges);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run22()
    {
        var k = 7;
        int[] nums = [2, 3];
        int[][] edges = [[0, 1]];
        var expected = 9;
        var result = new Solution2().MaximumValueSum(nums, k, edges);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run23()
    {
        var k = 3;
        int[] nums = [7, 7, 7, 7, 7, 7];
        int[][] edges = [[0, 1], [0, 2], [0, 3], [0, 4], [0, 5]];
        var expected = 42;
        var result = new Solution2().MaximumValueSum(nums, k, edges);
        Assert.Equal(expected, result);
    }
}