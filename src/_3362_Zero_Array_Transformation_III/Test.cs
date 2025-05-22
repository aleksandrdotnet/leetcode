namespace _3362_Zero_Array_Transformation_III;

public class Test
{
    [Fact]
    public void Run1()
    {
        var expected = 1;
        var q = new int[][] { [0, 2], [0, 2], [1, 1] };
        var result = new Solution().MaxRemoval([2, 0, 2], q);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Run2()
    {
        var expected = 2;
        var q = new int[][] { [1, 3], [0, 2], [1, 3], [1, 2] };
        var result = new Solution().MaxRemoval([1, 1, 1, 1], q);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Run3()
    {
        var expected = -1;
        var q = new int[][] { [0, 3] };
        var result = new Solution().MaxRemoval([1, 2, 3, 4], q);
        Assert.Equal(expected, result);
    }
}