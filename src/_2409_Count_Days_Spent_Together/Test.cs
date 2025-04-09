namespace _2409_Count_Days_Spent_Together;

public class Test
{
    [Theory]
    [InlineData("08-15", "08-18", "08-16", "08-19", 3)]
    [InlineData("10-01", "10-31", "11-01", "12-31", 0)]
    [InlineData("09-01", "10-19", "06-19", "10-20", 49)]
    public void Run(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob, int expected)
    {
        var result = new Solution().CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("08-15", "08-18", "08-16", "08-19", 3)]
    [InlineData("10-01", "10-31", "11-01", "12-31", 0)]
    [InlineData("09-01", "10-19", "06-19", "10-20", 49)]
    public void Run2(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob, int expected)
    {
        var result = new Solution2().CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);
        Assert.Equal(expected, result);
    }
}