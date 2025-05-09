namespace _3343_Count_Number_of_Balanced_Permutations;

public class Test
{
    [Theory]
    [InlineData()]
    public void Run(string num, int expected)
    {
        var result = new Solution().CountBalancedPermutations(num);
        Assert.Equal(expected, result);
    }
}