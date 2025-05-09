namespace _3343_Count_Number_of_Balanced_Permutations;

public class Test
{
    [Theory]
    [InlineData("123", 2)]
    [InlineData("112", 1)]
    [InlineData("12345", 0)]
    public void Run(string num, int expected)
    {
        var result = new Solution().CountBalancedPermutations(num);
        Assert.Equal(expected, result);
    }
}