using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _1789_Primary_Department_for_Each_Employee;

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
select 
    emp.employee_id,
    emp.department_id
from 
    Employee emp
where
    emp.primary_flag = 'Y'
group by 
    emp.employee_id,
    emp.department_id

union all

select 
    emp.employee_id,
    max(emp.department_id)
from 
    Employee emp
group by 
     emp.employee_id
having
    count(*) = 1
")
            .ToList();

        var expected = new List<Result>
        {
            new(1,1),
            new(2,1),
            new(3,3),
            new(4,3)
        };

        Assert.Equal(expected.Count, result.Count);
        expected.Should().BeEquivalentTo(result);
    }
    
    public class Result
    {
        public int employee_id { get; set; }
        public int department_id { get; set; }

        public Result()
        {
            
        }
        public Result(int employeeId, int departmentId)
        {
            employee_id = employeeId;
            department_id = departmentId;
        }
    }
}