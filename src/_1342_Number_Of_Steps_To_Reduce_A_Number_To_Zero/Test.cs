namespace _1342_Number_Of_Steps_To_Reduce_A_Number_To_Zero;

public class Test
{
    [Theory]
    [InlineData(14, 6)]
    [InlineData(8, 4)]
    [InlineData(123, 12)]
    public void Run(int input, int output)
    {
        var result = Solution.Run(input);

        Assert.Equal(output, result);
    }
}