namespace _3341_Find_Minimum_Time_to_Reach_Last_Room_I;

public class Test
{
    [Fact]
    public void Run()
    {
        var moveTime = new[] { new[] { 0, 4 }, new[] { 4, 4 } };
        var expected = 6;
        var result = new Solution().MinTimeToReach(moveTime);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run2()
    {
        var moveTime = new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } };
        var expected = 3;
        var result = new Solution().MinTimeToReach(moveTime);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Run3()
    {
        var moveTime = new[] { new[] { 0, 1 }, new[] { 1, 2 } };
        var expected = 3;
        var result = new Solution().MinTimeToReach(moveTime);
        Assert.Equal(expected, result);
    }
}