using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _619_Biggest_Single_Number;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
/* Write your T-SQL query statement below */
;with cte as (select
    mn.num
from
    MyNumbers mn
group by 
    mn.num
having 
    count(1) = 1
)

select
    max(c.num) [num]
from
    cte c")
            .ToList();


        var expected = new List<Result>
        {
            new(6)
        };

        Assert.Equal(expected.Count, result.Count);
        result.Should().BeEquivalentTo(expected);
    }

    public class Result
    {
        public Result()
        {
        }

        public Result(int num)
        {
            Num = num;
        }
        public int Num { get; set; }
    }
}