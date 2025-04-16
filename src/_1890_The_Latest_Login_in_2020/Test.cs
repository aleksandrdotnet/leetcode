using Microsoft.EntityFrameworkCore;

namespace _1890_The_Latest_Login_in_2020;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
SELECT
    UserId,
    MAX(TimeStamp) AS TimeStamp
FROM Logins
WHERE TimeStamp >= '2020-01-01 00:00:00' and TimeStamp < '2021-01-01 00:00:00'
GROUP BY UserId;")
            .ToList();

        var expected = new List<Result>
        {
            new() { UserId = 6, TimeStamp = DateTime.Parse("2020-06-30 15:06:07") },
            new() { UserId = 8, TimeStamp = DateTime.Parse("2020-12-30 00:46:50") },
            new() { UserId = 2, TimeStamp = DateTime.Parse("2020-01-16 02:49:50") }
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result,
                r => r.UserId == exp.UserId && r.TimeStamp == exp.TimeStamp);
    }
    
    [Fact]
    public void CTE_Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
;with CTE as(
    select
        UserId,
        TimeStamp,
        ROW_NUMBER() OVER (PARTITION BY UserId ORDER BY TimeStamp desc) as [RN]
    from
        Logins
    where
        TimeStamp >= '2020-01-01 00:00:00' and TimeStamp < '2021-01-01 00:00:00'
)

 select
     UserId,
     TimeStamp [TimeStamp]
 from
     CTE
 where
     RN = 1")
            .ToList();

        var expected = new List<Result>
        {
            new() { UserId = 6, TimeStamp = DateTime.Parse("2020-06-30 15:06:07") },
            new() { UserId = 8, TimeStamp = DateTime.Parse("2020-12-30 00:46:50") },
            new() { UserId = 2, TimeStamp = DateTime.Parse("2020-01-16 02:49:50") }
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result,
                r => r.UserId == exp.UserId && r.TimeStamp == exp.TimeStamp);
    }

    public class Result
    {
        public int UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}