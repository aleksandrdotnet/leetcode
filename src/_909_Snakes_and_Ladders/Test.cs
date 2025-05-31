namespace _909_Snakes_and_Ladders;

public class Test
{
    [Fact]
    public void Run1()
    {
        int[][] board =
        [
            [-1, -1, -1, -1, -1, -1], [-1, -1, -1, -1, -1, -1], [-1, -1, -1, -1, -1, -1], [-1, 35, -1, -1, 13, -1],
            [-1, -1, -1, -1, -1, -1], [-1, 15, -1, -1, -1, -1]
        ];
        var expected = 4;
        var result = new Solution().SnakesAndLadders(board);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        int[][] board =
            [[-1, -1], [-1, 3]];
        var expected = 1;
        var result = new Solution().SnakesAndLadders(board);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Run3()
    {
        int[][] board = [[-1,-1],[-1,1]];
        var expected = 1;
        var result = new Solution().SnakesAndLadders(board);
        Assert.Equal(expected, result);
    }

    // 7 8 9 
    // 6 9 8 
    // 1 8 9 
    [Fact]
    public void Run4()
    {
        int[][] board = [[-1, -1, -1], [-1, 9, 8], [-1, 8, 9]];
        var expected = 1;
        var result = new Solution().SnakesAndLadders(board);
        Assert.Equal(expected, result);
    }
    
    //  1  1 -1 
    //  1  1  1
    // -1  1  1
    [Fact]
    public void Run5()
    {
        int[][] board = [[1,1,-1],[1,1,1],[-1,1,1]];
        var expected = -1;
        var result = new Solution().SnakesAndLadders(board);
        Assert.Equal(expected, result);
    }
    
    // 16 11  6 13      00 01 02 03
    //  9 15 16 12      10 11 12 13
    //  8  7  6  8  ->  20 21 22 23
    //  1  2  3  8      30 31 32 33
    [Fact]
    public void Run6()
    {
        int[][] board = [[-1, 11, 6, -1], [-1, 15, 16, -1], [-1, 7, -1, 8], [-1, -1, -1, 8]];
        var expected = 2;
        var result = new Solution().SnakesAndLadders(board);
        Assert.Equal(expected, result);
    }
}