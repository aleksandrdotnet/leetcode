namespace _73_Set_Matrix_Zeroes;

public class Test
{
    [Fact]
    public void Run1()
    {
        var matrix = new int[][] { [1, 1, 1], [1, 0, 1], [1, 1, 1] };
        var expected = new int[][] { [1, 0, 1], [0, 0, 0], [1, 0, 1] };

        new Solution().SetZeroes(matrix);
        Assert.Equal(expected, matrix);
    }

    [Fact]
    public void Run2()
    {
        var matrix = new int[][] { [0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5] };
        var expected = new int[][] { [0, 0, 0, 0], [0, 4, 5, 0], [0, 3, 1, 0] };

        new Solution().SetZeroes(matrix);
        Assert.Equal(expected, matrix);
    }
}