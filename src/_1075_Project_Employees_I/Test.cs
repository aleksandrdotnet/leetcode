using Microsoft.EntityFrameworkCore;

namespace _1075_Project_Employees_I;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>(
                $@"select p.ProjectId as Id, ROUND(AVG(CAST(e.ExperienceYears AS DECIMAL(10,2))), 2) as Exp
from Projects p
inner join Employees e on e.EmployeeId = p.EmployeeId
group by p.ProjectId")
            .ToList();


        var expected = new List<(int ProjectId, double Exp)>
        {
            (1, 2),
            (2, 2.5)
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected) Assert.Contains(result, r => r.Id == exp.ProjectId && r.Exp == exp.Exp);
    }

    public class Result
    {
        public int Id { get; set; }
        public double Exp { get; set; }
    }
}