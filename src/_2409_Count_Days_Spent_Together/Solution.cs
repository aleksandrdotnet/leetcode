using System.Globalization;

namespace _2409_Count_Days_Spent_Together;

public class Solution
{
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var aliceStart = DateTime.ParseExact($"{arriveAlice}-2025", "MM-dd-yyyy", CultureInfo.InvariantCulture);
        var aliceEnd = DateTime.ParseExact($"{leaveAlice}-2025", "MM-dd-yyyy", CultureInfo.InvariantCulture);

        var bobStart = DateTime.ParseExact($"{arriveBob}-2025", "MM-dd-yyyy", CultureInfo.InvariantCulture);
        var bobEnd = DateTime.ParseExact($"{leaveBob}-2025", "MM-dd-yyyy", CultureInfo.InvariantCulture);

        var start = aliceStart > bobStart ? aliceStart : bobStart;
        var end = aliceEnd < bobEnd ? aliceEnd : bobEnd;

        if (start > end)
            return 0;

        return (end - start).Days + 1;
    }
}

public class Solution2
{
    private static readonly int[] Days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var aliceStart = CountDaysInternal(arriveAlice);
        var aliceEnd = CountDaysInternal(leaveAlice);

        var bobStart = CountDaysInternal(arriveBob);
        var bobEnd = CountDaysInternal(leaveBob);

        return Math.Max(0, Math.Min(aliceEnd, bobEnd) - Math.Max(aliceStart, bobStart) + 1);
    }

    private int CountDaysInternal(ReadOnlySpan<char> date)
    {
        var m = int.Parse(date[..2]);
        var d = int.Parse(date[3..5]);

        return Days[..(m - 1)].Sum() + d;
    }
}