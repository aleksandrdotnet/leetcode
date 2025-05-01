namespace _2071_Maximum_Number_of_Tasks_You_Can_Assign;

public class Test
{
    [Theory]
    [InlineData(new[] { 3, 2, 1 }, new[] { 0, 3, 3 }, 1, 1, 3)]
    [InlineData(new[] { 5, 4 }, new[] { 0, 0, 0 }, 1, 5, 1)]
    [InlineData(new[] { 10, 15, 30 }, new[] { 0, 10, 10, 10, 10 }, 3, 10, 2)]
    [InlineData(new[] { 5, 9, 8, 5, 9 }, new[] { 1, 6, 4, 2, 6 }, 1, 5, 3)]
    public void Run(int[] tasks, int[] workers, int pills, int strength, int expected)
    {
        var result = new Solution().MaxTaskAssign(tasks, workers, pills, strength);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 3, 2, 1 }, new[] { 0, 3, 3 }, 1, 1, 3)]
    [InlineData(new[] { 5, 4 }, new[] { 0, 0, 0 }, 1, 5, 1)]
    [InlineData(new[] { 10, 15, 30 }, new[] { 0, 10, 10, 10, 10 }, 3, 10, 2)]
    [InlineData(new[] { 5, 9, 8, 5, 9 }, new[] { 1, 6, 4, 2, 6 }, 1, 5, 3)]
    public void Run2(int[] tasks, int[] workers, int pills, int strength, int expected)
    {
        var result = new Solution2().MaxTaskAssign(tasks, workers, pills, strength);
        Assert.Equal(expected, result);
    }
}