namespace _3342_Find_Minimum_Time_to_Reach_Last_Room_II;

public class Test
{
    [Theory]
    [InlineData()]
    public void Run(int[][] moveTime, int expected)
    {
        var result = new Solution().MinTimeToReach(moveTime);
        Assert.Equal(expected, result);
    }
}