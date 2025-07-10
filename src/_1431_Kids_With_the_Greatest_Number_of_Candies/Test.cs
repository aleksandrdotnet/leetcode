namespace _1431_Kids_With_the_Greatest_Number_of_Candies;

public class Test
{
    [Theory]
    [InlineData(new[] { 2, 3, 5, 1, 3 }, 3, new[] { true, true, true, false, true })]
    [InlineData(new[] { 4, 2, 1, 1, 2 }, 1, new[] { true, false, false, false, false })]
    [InlineData(new[] { 12, 1, 12 }, 10, new[] { true, false, true })]
    public void Run(int[] candies, int extraCandies, IList<bool> expected)
    {
        var result = new Solution().KidsWithCandies(candies, extraCandies);
        Assert.Equal(expected, result);
    }
}