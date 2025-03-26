namespace _448_Find_All_Numbers_Disappeared_in_an_Array;

public class Test
{
    [Theory]
    [InlineData(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 5, 6 })]
    [InlineData(new[] { 1, 1 }, new[] { 2 })]
    [InlineData(new[] { 2, 2 }, new[] { 1 })]
    [InlineData(new[] { 1, 1, 2, 2 }, new[] { 3, 4 })]
    public void Run(int[] nums, IList<int> expected)
    {
        var result = new Solution().FindDisappearedNumbers(nums);
        Assert.Equal(expected, result);
    }
}