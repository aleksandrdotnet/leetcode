namespace _73_Set_Matrix_Zeroes;

public class Test
{
    [Theory]
    [InlineData()]
    public void Run(int[][] matrix, void expected)
    {
        var result = new Solution().SetZeroes(matrix);
        Assert.Equal(expected, result);
    }
}