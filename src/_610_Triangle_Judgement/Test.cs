using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _610_Triangle_Judgement;

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
    x,
    y,
    z,
    case 
        when x + y > z and x + z > y and y + z > x then 'Yes'
        else 'No'
    end [triangle]
from
    Triangle
")
            .ToList();


        var expected = new List<Result>
        {
            new(13, 15, 30, "No"),
            new(10, 20, 15, "Yes"),
        };

        Assert.Equal(expected.Count, result.Count());
        result.Should().BeEquivalentTo(expected);
    }

    public class Result
    {
        public Result()
        {
        }

        public Result(int x, int y, int z, string triangle)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.triangle = triangle;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public string triangle { get; set; }
    }
}