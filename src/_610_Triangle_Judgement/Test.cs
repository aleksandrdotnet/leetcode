using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _596_Classes_With_at_Least_5_Students;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
select
    c.class []
from
    Courses c
group by
    c.class
having count(1) >= 5
                             ")
            .ToList();


        var expected = new List<Result>
        {
            new("Math")
        };

        Assert.Equal(expected.Count, result.Count());
        result.Should().BeEquivalentTo(expected);
    }

    public class Result
    {
        public Result()
        {
        }

        public Result(string @class)
        {
            Class = @class;
        }

        public string Class { get; set; }
    }
}