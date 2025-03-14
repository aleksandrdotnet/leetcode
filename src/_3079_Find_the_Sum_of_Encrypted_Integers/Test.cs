namespace _3079_Find_the_Sum_of_Encrypted_Integers;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 6)]
    [InlineData(new[] { 10, 21, 31 }, 66)]
    public void Run(int[] input, int expected)
    {
        var result = Solution.SumOfEncryptedInt(input);

        Assert.Equal(expected, result);
    }
}