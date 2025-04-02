using Microsoft.EntityFrameworkCore;

namespace _577_Employee_Bonus;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        // var result = from e in context.Employees
        //     join b in context.Bonuses on e.EmpId equals b.EmpId into empBonus
        //     from eb in empBonus.DefaultIfEmpty()
        //     where (eb.BonusAmount ?? 0) < 1000
        //     select new { e.Name, Bonus = eb.BonusAmount };

        var result = context.Database.SqlQuery<NameBonus>($@"SELECT emp.name, b.BonusAmount AS Bonus 
                             FROM Employees emp 
                             LEFT JOIN Bonuses b ON b.empId = emp.empId 
                             WHERE b.BonusAmount IS NULL OR b.BonusAmount < 1000")
            .ToList();


        var expected = new List<(string Name, int? Bonus)>
        {
            ("Brad", null),
            ("John", null),
            ("Dan", 500)
        };

        Assert.Equal(expected.Count, result.Count());
        foreach (var exp in expected) Assert.Contains(result, r => r.Name == exp.Name && r.Bonus == exp.Bonus);
    }

    public class NameBonus
    {
        public string Name { get; set; }
        public int? Bonus { get; set; }
    }
}