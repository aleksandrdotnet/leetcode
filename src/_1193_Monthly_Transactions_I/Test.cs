using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _1193_Monthly_Transactions_I;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>(
                $@"
SELECT
    strftime('%Y-%m', t1.trans_date) AS month,
    t1.country,
    COUNT(1) AS trans_count,
    SUM(CASE WHEN t1.state = 'approved' THEN 1 ELSE 0 END) AS approved_count,
    SUM(IFNULL(t1.amount, 0)) AS trans_total_amount,
    SUM(CASE WHEN t1.state = 'approved' THEN IFNULL(t1.amount, 0) ELSE 0 END) AS approved_total_amount
FROM
    Transactions t1
GROUP BY
    strftime('%Y-%m', t1.trans_date), t1.country;
")
            .ToList();

        var expected = new List<Result>
        {
            new("2018-12", "US", 2, 1, 3000, 1000),
            new("2019-01", "US", 1, 1, 2000, 2000),
            new("2019-01", "DE", 1, 1, 2000, 2000)
        };

        Assert.Equal(expected.Count, result.Count);
        result.Should().BeEquivalentTo(expected);
    }

    public class Result
    {
        public Result()
        {
        }

        public Result(string month, string country, int transCount, int approvedCount, int transTotalAmount,
            int approvedTotalAmount)
        {
            this.month = month;
            this.country = country;
            trans_count = transCount;
            approved_count = approvedCount;
            trans_total_amount = transTotalAmount;
            approved_total_amount = approvedTotalAmount;
        }

        public string month { get; set; }
        public string country { get; set; }
        public int trans_count { get; set; }
        public int approved_count { get; set; }
        public int trans_total_amount { get; set; }
        public int approved_total_amount { get; set; }
    }
}