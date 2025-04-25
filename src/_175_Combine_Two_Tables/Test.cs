using Microsoft.EntityFrameworkCore;

namespace _175_Combine_Two_Tables;

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
    p.firstName [FirstName],
    p.lastName [LastName],
    a.city [City],
    a.state [State]
from Person p
left outer join Address a on a.PersonId = p.PersonId")
            .ToList();

        var expected = new List<Result>
        {
            new() { FirstName = "Allen", LastName = "Wang", City = null, State = null },
            new() { FirstName = "Bob", LastName = "Alice", City = "New York City", State = "New York" }
        };

        Assert.Equal(expected.Count, result.Count);
        Assert.Equivalent(expected, result);
    }


    public class Result
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}