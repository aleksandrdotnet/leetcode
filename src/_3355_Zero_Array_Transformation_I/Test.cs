namespace _3355_Zero_Array_Transformation_I;

public class Test
{
    [Fact]
    public void Run1()
    {
        var expected = true;
        var q = new int[][] { [0, 2] };
        var result = new Solution().IsZeroArray([1, 0, 1], q);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        var expected = false;
        var q = new int[][] { [1, 3], [0, 2] };
        var result = new Solution().IsZeroArray([4, 3, 2, 1], q);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run21()
    {
        var expected = true;
        var q = new int[][] { [0, 2] };
        var result = new Solution2().IsZeroArray([1, 0, 1], q);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run22()
    {
        var expected = false;
        var q = new int[][] { [1, 3], [0, 2] };
        var result = new Solution2().IsZeroArray([4, 3, 2, 1], q);
        Assert.Equal(expected, result);
    }
}