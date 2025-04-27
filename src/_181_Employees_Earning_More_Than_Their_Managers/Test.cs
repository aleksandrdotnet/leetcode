using Microsoft.EntityFrameworkCore;

namespace _181_Employees_Earning_More_Than_Their_Managers;

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
    emp.name [Employee]
from Employee emp
inner join Employee mngr on emp.managerId = mngr.id
where emp.salary > mngr.salary")
            .ToList();

        var expected = new List<Result>
        {
            new() { Employee = "Joe" }
        };

        Assert.Equal(expected.Count, result.Count);
        Assert.Equivalent(expected, result);
    }


    private class Result
    {
        public required string Employee { get; set; }
    }
}