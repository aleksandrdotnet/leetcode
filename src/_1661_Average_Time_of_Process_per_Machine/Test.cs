using Microsoft.EntityFrameworkCore;

namespace _1661_Average_Time_of_Process_per_Machine;

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
    a1.machine_id,
    round(avg(a2.timestamp) - avg(a1.timestamp), 3) [processing_time]
from
    Activity a1
        inner join Activity a2 on a1.machine_id = a2.machine_id
        and a1.process_id = a2.process_id
        and a1.activity_type <> a2.activity_type
where
    a1.activity_type = 'Start'
group by
    a1.machine_id")
            .ToList();


        var expected = new List<(int machine_id, double processing_time)>
        {
            (0, 0.894),
            (1, 0.995),
            (2, 1.456)
        };

        Assert.Equal(expected.Count, result.Count);
        foreach (var exp in expected)
            Assert.Contains(result, r => r.machine_id == exp.machine_id && r.processing_time == exp.processing_time);
    }

    public class Result
    {
        public int machine_id { get; set; }
        public double processing_time { get; set; }
    }
}