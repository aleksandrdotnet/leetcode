using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _1174_Immediate_Food_Delivery_II;

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
WITH cte AS (
    SELECT
        d.customer_id,
        ROW_NUMBER() OVER (PARTITION BY d.customer_id ORDER BY d.order_date ASC) AS row_num,
        CASE
            WHEN d.order_date = d.customer_pref_delivery_date THEN 'immediate'
            ELSE 'scheduled'
        END AS sc
    FROM
        Delivery d
)
SELECT
    ROUND(SUM(CASE WHEN c.sc = 'immediate' THEN 1 ELSE 0 END) * 100.0 / COUNT(1), 2) AS immediate_percentage
FROM
    cte c
WHERE
    c.row_num = 1;
")
            .ToList();

        var expected = new List<Result>
        {
            new(50.0f)
        };

        Assert.Equal(expected.Count, result.Count);
        result.Should().BeEquivalentTo(expected);
    }

    public class Result
    {
        public Result()
        {
        }

        public Result(float immediatePercentage)
        {
            immediate_percentage = immediatePercentage;
        }

        public float immediate_percentage { get; set; }
    }
}