using FluentAssertions;
using Microsoft.EntityFrameworkCore;

namespace _2356_Number_of_Unique_Subjects_Taught_by_Each_Teacher;

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
select 
    c.teacher_id,
    count(distinct c.subject_id) [cnt]
from 
    Teacher c
group by
    c.teacher_id
")
            .ToList();

        var expected = new List<Result>
        {
            new(1, 2),
            new(2, 4)
        };

        Assert.Equal(expected.Count, result.Count);
        result.Should().BeEquivalentTo(expected);
    }

    public class Result
    {
        public Result()
        {
        }

        public Result(int teacherId, int cnt)
        {
            teacher_id = teacherId;
            this.cnt = cnt;
        }

        public int teacher_id { get; set; }
        public int cnt { get; set; }
    }
}