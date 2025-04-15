using Microsoft.EntityFrameworkCore;

namespace _1757_Recyclable_and_Low_Fat_Products;

public class Test
{
    [Fact]
    public void CTE_Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
select
    product_id
from
    Products
where 
    low_fats = 'Y' AND recyclable = 'Y'")
            .ToList();

        var expected = new List<(string Department, string Employee, int Salary)>
        {
            ("IT", "Joe", 85000),
            ("Sales", "Henry", 80000),
            ("Sales", "Sam", 60000),
            ("IT", "Max", 90000),
            ("IT", "Randy", 85000),
            ("IT", "Will", 70000)
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result,
                r => r.Department == exp.Department
                     && r.Employee == exp.Employee
                     && r.Salary == exp.Salary);
    }

    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"
SELECT
    d.name AS Department,
    e.name AS Employee,
    e.salary AS Salary
FROM Department d
LEFT JOIN (
    SELECT 
        emp.departmentId,
        emp.name,
        emp.salary,
        DENSE_RANK() OVER (
            PARTITION BY emp.departmentId 
            ORDER BY emp.salary DESC
        ) AS dr
    FROM Employee emp
) e ON e.departmentId = d.id
WHERE e.dr <= 3;
")
            .ToList();

        var expected = new List<(string Department, string Employee, int Salary)>
        {
            ("IT", "Joe", 85000),
            ("Sales", "Henry", 80000),
            ("Sales", "Sam", 60000),
            ("IT", "Max", 90000),
            ("IT", "Randy", 85000),
            ("IT", "Will", 70000)
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result,
                r => r.Department == exp.Department
                     && r.Employee == exp.Employee
                     && r.Salary == exp.Salary);
    }

    public class Result
    {
        public string Department { get; set; }
        public string Employee { get; set; }
        public int Salary { get; set; }
    }
}