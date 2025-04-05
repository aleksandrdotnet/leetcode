using Microsoft.EntityFrameworkCore;

namespace _1729_Find_Followers_Count;

public class Test
{
    [Fact]
    public void Query_Should_Return_Correct_Result()
    {
        using var context = new Solution.AppDbContext();

        context.Database.OpenConnection();

        context.Database.EnsureCreated();

        var result = context.Database.SqlQuery<Result>($@"select x.user_id as Id, count(1) as Count from Followers x
group by x.user_id
order by x.user_id")
            .ToList();


        var expected = new List<(int id, int count)>
        {
            (0, 1),
            (1, 1),
            (2, 2)
        };

        Assert.Equal(expected.Count, result.Count());
        foreach (var exp in expected) Assert.Contains(result, r => r.Id == exp.id && r.Count == exp.count);
    }

    public class Result
    {
        public int Id { get; set; }
        public int Count { get; set; }
    }
}